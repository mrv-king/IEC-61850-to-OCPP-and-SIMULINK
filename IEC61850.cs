using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charging_point_digital_twin
{
    class IEC61850
    {
        private string name;
        private string type;
        private string first_cont_name;
        private string second_cont_name;
        private List<string> con;

        public IEC61850(string type, string name, string first_cont_name, string second_cont_name)
        {
            this.type = type;
            this.name = name;
            this.first_cont_name = first_cont_name;
            this.second_cont_name = second_cont_name;
            this.con = new List<string>();
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FirstContName
        {
            get { return first_cont_name; }
            set { first_cont_name = value; }
        }

        public string SecondContName
        {
            get { return second_cont_name; }
            set { second_cont_name = value; }
        }

        public string Connection
        {
            get
            {
                if (con.Count > 0)
                    return con.First();
                else
                    return null;
            }
            set { con.Add(value); }
        }

        public void ConnectionRemove(string Connection)
        {
            con.Remove(Connection);
        }

        public bool ConnectionFind(string Connection)
        {
            return con.Contains(Connection);
        }

    }
}
