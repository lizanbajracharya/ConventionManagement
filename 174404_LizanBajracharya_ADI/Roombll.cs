using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class Roombll
    {
        private string location;
        private string capacity;
        private string technical;
        private int id;

        public string Location { get => location; set => location = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Technical { get => technical; set => technical = value; }
        public int Id { get => id; set => id = value; }

        Dbconnection conn = new Dbconnection();

        public void add()
        {
            string query = "insert into RoomStallLocation(Locations,Capacity,TechnicalResources,Statuss)values('"+Location+"','"+Capacity+"','"+Technical+"','Unbooked')";
            conn.Manipulate(query);
        }

        public void add2()
        {
            string query = "insert into StallLocation(Locations,Capacity,TechnicalResources,Statuss)values('" + Location + "','" + Capacity + "','" + Technical + "','Unbooked')";
            conn.Manipulate(query);
        }

        public DataTable datagridload()
        {
            string query = "select Locationid,Locations,Capacity,TechnicalResources from StallLocation";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public DataTable datagridloads()
        {
            string query = "select id,Locations,Capacity,TechnicalResources from RoomStallLocation";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void Delete()
        {
            string query = "Delete from StallLocation where Locationid="+Id;
            string query1 = "Delete from Stall where Locationid=" + Id;
            
            conn.Manipulate(query1);
            conn.Manipulate(query);
        }

        public void Delete1()
        {
            string query = "Delete from RoomStallLocation where id=" + Id;
            string query1 = "Delete from Stall where id=" + Id;

            conn.Manipulate(query1);
            conn.Manipulate(query);
        }

        public void updatestall()
        {
            string query = "Update StallLocation set Locations='" + location + "',Capacity='" + capacity + "',TechnicalResources='" + technical + "' where Locationid="+id;
            conn.Manipulate(query);
        }

        public void updateroom()
        {
            string query = "Update RoomStallLocation set Locations='" + location + "',Capacity='" + capacity + "',TechnicalResources='" + technical + "' where id=" + id;
            conn.Manipulate(query);
        }
    }
}
