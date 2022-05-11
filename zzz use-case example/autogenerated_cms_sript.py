import asyncio
import logging
import websockets
import sys, select

from datetime import datetime
from ocpp.routing import on
from ocpp.v201 import call
from ocpp.v201 import ChargePoint as cp
from ocpp.v201 import call_result
from inputimeout import inputimeout, TimeoutOccurred

logging.basicConfig(level=logging.INFO)

class ChargePoint(cp):
    @on('BootNotification')
    async def on_boot_notification(self, charging_station, reason, **kwargs):
        return call_result.BootNotificationPayload(
            current_time=datetime.utcnow().isoformat(),
            interval=10,
            status='Accepted'
        )
        
    @on('Heartbeat')
    async def on_heartbeat_rquest(self):
        return call_result.HeartbeatPayload(
                current_time = datetime.utcnow().isoformat()
            )    

    async def get_variables(self, name):         
        request = call.GetVariablesPayload(
            get_variable_data=[
                {'component': {'name': name},
                'variable': {'name': 'switch_status'}}
                ]
            )
        response = await self.call(request)
        if response.get_variable_result[0].get('attribute_status') == 'Accepted':
            print ('Variable has been updated successfully!')
            return response.get_variable_result[0].get('attribute_value')
        else:
            print ('Failed to get variable value!')
            return 'NULL'
 
    async def set_variables(self, component_name, new_value):
        request = call.SetVariablesPayload(
            set_variable_data=[
                {'component': {'name': component_name},
                'variable': {'name': 'switch_state_changed'},
                'attribute_value': new_value}               
	        ]
        )    
        response = await self.call(request)
        if response.set_variable_result[0].get('attribute_status') == 'Accepted':
            print('Variable has been updated successfully!')
            return True
        else:
            print ('Failed to set variable value!')
            return False

async def on_connect(websocket, path):
    # For every new charge point that connects, create a ChargePoint
    # instance and start listening for messages.
    #
    try:
        requested_protocols = websocket.request_headers[
            'Sec-WebSocket-Protocol']
    except KeyError:
        logging.info('Client has not requested any Subprotocol. '
                 'Closing Connection')
    if websocket.subprotocol:
        logging.info('Protocols Matched: %s', websocket.subprotocol)
    else:
        # In the websockets lib if no subprotocols are supported by the
        # client and the server, it proceeds without a subprotocol,
        # so we have to manually close the connection.
        logging.warning('Protocols Mismatched | Expected Subprotocols: %s,'
                        ' but client supports  %s | Closing connection',
                        websocket.available_subprotocols,
                        requested_protocols)
        return await websocket.close()

    charge_point_id = path.strip('/')
    cp = ChargePoint(charge_point_id, websocket)

    await asyncio.gather(cp.start(), execute_cmd(cp))

async def main():
    server = await websockets.serve(
        on_connect,
        '127.0.0.1',
        8080,
        subprotocols=['ocpp2.0.1']
    )
    logging.info('WebSocket Server Started')
    await server.wait_closed()
    
async def execute_cmd(cp):
    while True:
        await asyncio.sleep(1)
        try:
            user_input = inputimeout(prompt='>>', timeout=10)
            is_exist = await execute_if_command_and_parameter_exist(cp, user_input)      
            if is_exist == '-1':
                print ('The command: '+user_input.split()[0]+' is not correct!')
            if is_exist == '-2':
                print ('The parametr: '+user_input.split()[1]+' is not correct!')  
        except TimeoutOccurred:
            pass
        
async def execute_if_command_and_parameter_exist(cp, user_input):
    list_of_words = user_input.split()
    
    if list_of_words[0] == 'read': 
        if list_of_words[1] in globals():
            new_value = await cp.get_variables(list_of_words[1]) 
            if new_value != 'NULL':
                globals()[list_of_words[1]] = int(new_value)        
                return '1'
        else:
            return '-2'
    elif list_of_words[0] == 'write':
        if list_of_words[1] in globals():
            if await cp.set_variables(list_of_words[1], list_of_words[2]) == True:
                globals()[list_of_words[1]] = int(list_of_words[2])            
            return '1'
        else:
            return '-2'
    else:
        return '-1'
    if list_of_words[0] == 'exit' or list_of_words[0] == 'quit':
        exit(0)

_CB10 = 0
_CB11 = 0
_CB12 = 0

if __name__ == '__main__':
    asyncio.run(main())