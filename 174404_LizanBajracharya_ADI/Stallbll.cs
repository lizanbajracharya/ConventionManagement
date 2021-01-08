using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class Stallbll
    {
        private string Location;
        private string Size;
        private string Attendee;
        private string Day;
        private string type;
        private int id;

        public string Location1 { get => Location; set => Location = value; }
        public string Size1 { get => Size; set => Size = value; }
        public string Attendee1 { get => Attendee; set => Attendee = value; }
        public string Day1 { get => Day; set => Day = value; }
        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }

        Dbconnection conn = new Dbconnection();
        public void add()
        {
            string query = "insert into Stall(Locationid,Size,Attendeeid,Exhibitionday,TypeofStall)values('"+Location1+"','"+Size1+"','"+Attendee1+"','"+Day1+"','"+Type+"')";
            conn.Manipulate(query);
        }

        public DataTable load()
        {
            string query;
            query = "Select Firstname,Attendeeid,Statuss from Attendee where Statuss='NotBooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public string attendeid()
        {
            string query = "select Attendeeid from Attendee where Statuss='NotBooked'";
            DataTable dt = conn.Retrieve(query);
            return dt.Rows[0][0].ToString();
        }

        public void updatestatus()
        {
            string query = "Update Attendee set Statuss='Booked' where Statuss='NotBooked' and Attendeeid="+attendeid();
            conn.Manipulate(query);
        }

        public DataTable Locationload()
        {
            string query = "Select Locationid,Locations,Statuss from StallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }


        public DataTable Sizeload()
        {
            string query = "Select Locationid,Capacity,Statuss from StallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public DataTable datagridload()
        {
            string query = "select s.Stallid,a.Firstname,s.Exhibitionday,st.Capacity,s.TypeofStall from Stall s,Attendee a,StallLocation st where a.Attendeeid=s.Attendeeid and st.Locationid=s.Locationid";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void Delete()
        {
            string query = "delete from Stall where Stallid="+Id;
            conn.Manipulate(query);
        }

        public string locationid()
        {
            string query = "select Locationid from StallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt.Rows[0][0].ToString();
        }

        public void updatesize()
        {
            string query = "Update StallLocation set Statuss='Booked' where Statuss='Unbooked' and Locationid=" + locationid();
            conn.Manipulate(query);
        }

        

    }
}
