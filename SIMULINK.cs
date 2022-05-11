using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charging_point_digital_twin
{
    class SIMULINK
    {
        private string path;
        private string name;
        private string port1;
        private string port2;
        private string port3;
        private string port4;
        private string port5;
        private string port6;
        private bool LConn_status;
        private bool RConn_status;
        private short r_side_number_of_cont;
        private short l_side_number_of_cont;

        public SIMULINK(string path, string name, string port1, string port2, string port3, string port4, string port5, string port6, bool LConn_status, bool RConn_status, short l_side_number_of_cont, short r_side_number_of_cont)
        {
            this.path = path;
            this.name = name;
            this.port1 = port1;
            this.port2 = port2;
            this.port3 = port3;
            this.port4 = port4;
            this.port5 = port5;
            this.port6 = port6;
            this.LConn_status = LConn_status;
            this.RConn_status = RConn_status;
            this.r_side_number_of_cont = r_side_number_of_cont;
            this.l_side_number_of_cont = l_side_number_of_cont;
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Port1
        {
            get { return port1; }
            set { port1 = value; }
        }
        public string Port2
        {
            get { return port2; }
            set { port2 = value; }
        }
        public string Port3
        {
            get { return port3; }
            set { port3 = value; }
        }
        public string Port4
        {
            get { return port4; }
            set { port4 = value; }
        }
        public string Port5
        {
            get { return port5; }
            set { port5 = value; }
        }
        public string Port6
        {
            get { return port6; }
            set { port6 = value; }
        }

        public bool LConnStatus
        {
            get { return LConn_status; }
            set { LConn_status = value; }
        }
        public bool RConnStatus
        {
            get { return RConn_status; }
            set { RConn_status = value; }
        }

        public short RsideNumberOfCont
        {
            get { return r_side_number_of_cont; }
            set { r_side_number_of_cont = value; }
        }
        public short LsideNumberOfCont
        {
            get { return l_side_number_of_cont; }
            set { l_side_number_of_cont = value; }
        }
    }
}
