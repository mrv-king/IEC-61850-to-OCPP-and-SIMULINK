<?xml version="1.0" encoding="UTF-8"?>
<SCL xmlns="http://www.iec.ch/61850/2003/SCL" xmlns:sxy="http://www.iec.ch/61850/2003/SCLcoordinates">
  <Header id="my_first_project" nameStructure="IEDName" revision="R000" toolID="Helinks STS" version="V0.0">
    <History/>
  </Header>
  <Substation desc="" name="MFS" sxy:x="18" sxy:y="7">
    <LNode lnClass="ITCI" lnInst="1" prefix="" ldInst="NCC" iedName="None" lnType="itci_IEC 61850-7-4:2007"/>
    <LNode lnClass="ITMI" lnInst="1" prefix="" ldInst="HMI" iedName="None" lnType="itmi_IEC 61850-7-4:2007"/>
    <VoltageLevel name="J">
      <Bay name="01">
        <ConductingEquipment name="CT10" sxy:x="6" type="CTR">
          <Terminal bayName="01" cNodeName="L1" name="T1" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L1"/>
          <Terminal bayName="01" cNodeName="L11" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L11"/>
          <SubEquipment name="L1" phase="A">
            <LNode lnClass="TCTR" lnInst="1" prefix="A" ldInst="CTR/CT0" iedName="None" lnType="tctr"/>
          </SubEquipment>
          <SubEquipment name="L2" phase="B">
            <LNode lnClass="TCTR" lnInst="2" prefix="B" ldInst="CTR/CT0" iedName="None" lnType="tctr"/>
          </SubEquipment>
          <SubEquipment name="L3" phase="C">
            <LNode lnClass="TCTR" lnInst="3" prefix="C" ldInst="CTR/CT0" iedName="None" lnType="tctr"/>
          </SubEquipment>
          <SubEquipment name="L4" phase="N">
            <LNode lnClass="TCTR" lnInst="4" prefix="N" ldInst="CTR/CT0" iedName="None" lnType="tctr"/>
          </SubEquipment>
        </ConductingEquipment>
        <ConductingEquipment name="VTR0" sxy:x="9" type="VTR">
          <Terminal bayName="01" cNodeName="L1" name="T1" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L1"/>
          <SubEquipment name="L1" phase="A">
            <LNode lnClass="TVTR" lnInst="1" prefix="A" ldInst="VTR/VTR0" iedName="None" lnType="tvtr"/>
          </SubEquipment>
          <SubEquipment name="L2" phase="B">
            <LNode lnClass="TVTR" lnInst="2" prefix="B" ldInst="VTR/VTR0" iedName="None" lnType="tvtr"/>
          </SubEquipment>
          <SubEquipment name="L3" phase="C">
            <LNode lnClass="TVTR" lnInst="3" prefix="C" ldInst="VTR/VTR0" iedName="None" lnType="tvtr"/>
          </SubEquipment>
          <SubEquipment name="L4" phase="N">
            <LNode lnClass="TVTR" lnInst="4" prefix="N" ldInst="VTR/VTR0" iedName="None" lnType="tvtr"/>
          </SubEquipment>
        </ConductingEquipment>
        <ConductingEquipment name="D10" sxy:x="3" type="CON">
          <LNode lnClass="ZCON" lnInst="1" prefix="D10" ldInst="CON/D0" iedName="None" lnType="zcon"/>
          <Terminal bayName="01" cNodeName="L11" name="T1" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L11"/>
          <Terminal bayName="01" cNodeName="L12" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L12"/>
        </ConductingEquipment>
        <ConductingEquipment name="D11" sxy:x="3" sxy:y="2" type="CON">
          <LNode lnClass="ZCON" lnInst="3" prefix="D11" ldInst="CON/D1" iedName="None" lnType="zcon"/>
          <Terminal bayName="01" cNodeName="L11" name="T1" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L11"/>
          <Terminal bayName="01" cNodeName="L13" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L13"/>
        </ConductingEquipment>
        <ConductingEquipment name="D12" sxy:x="3" sxy:y="4" type="CON">
          <LNode lnClass="ZCON" lnInst="4" prefix="D12" ldInst="CON/D2" iedName="None" lnType="zcon"/>
          <Terminal bayName="01" cNodeName="L11" name="T1" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L11"/>
          <Terminal bayName="01" cNodeName="L14" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L14"/>
        </ConductingEquipment>
        <ConductingEquipment name="CB10" type="CBR">
          <LNode lnClass="XCBR" lnInst="1" prefix="CB10" ldInst="CBR/CB10" iedName="None" lnType="xcbr"/>
          <LNode lnClass="CSWI" lnInst="1" prefix="CB10" ldInst="CBR/CB10" iedName="None" lnType="cswi"/>
          <LNode lnClass="CILO" lnInst="1" prefix="CB10" ldInst="CBR/CB10" iedName="None" lnType="cilo"/>
          <Terminal bayName="01" cNodeName="L12" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L12"/>
        </ConductingEquipment>
        <ConductingEquipment name="CB11" sxy:y="2" type="CBR">
          <LNode lnClass="XCBR" lnInst="2" prefix="CB11" ldInst="CBR/CB11" iedName="None" lnType="xcbr"/>
          <LNode lnClass="CSWI" lnInst="2" prefix="CB11" ldInst="CBR/CB11" iedName="None" lnType="cswi"/>
          <LNode lnClass="CILO" lnInst="2" prefix="CB11" ldInst="CBR/CB11" iedName="None" lnType="cilo"/>
          <Terminal bayName="01" cNodeName="L13" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L13"/>
        </ConductingEquipment>
        <ConductingEquipment name="CB12" sxy:y="4" type="CBR">
          <LNode lnClass="XCBR" lnInst="3" prefix="CB12" ldInst="CBR/CB12¨" iedName="None" lnType="xcbr"/>
          <LNode lnClass="CSWI" lnInst="3" prefix="CB12" ldInst="CBR/CB12¨" iedName="None" lnType="cswi"/>
          <LNode lnClass="CILO" lnInst="3" prefix="CB12" ldInst="CBR/CB12¨" iedName="None" lnType="cilo"/>
          <Terminal bayName="01" cNodeName="L14" name="T2" substationName="MFS" voltageLevelName="J" connectivityNode="MFS/J/01/L14"/>
        </ConductingEquipment>
        <ConnectivityNode name="grounded" pathName="MFS/J/null/grounded"/>
        <ConnectivityNode name="L1" pathName="MFS/J/01/L1"/>
        <ConnectivityNode name="L15" pathName="MFS/J/01/L15"/>
        <ConnectivityNode name="L11" pathName="MFS/J/01/L11"/>
        <ConnectivityNode name="L12" pathName="MFS/J/01/L12"/>
        <ConnectivityNode name="L13" pathName="MFS/J/01/L13"/>
        <ConnectivityNode name="L14" pathName="MFS/J/01/L14"/>
      </Bay>
    </VoltageLevel>
  </Substation>
</SCL>