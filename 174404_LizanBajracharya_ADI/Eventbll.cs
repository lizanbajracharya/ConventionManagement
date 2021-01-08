using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class Eventbll
    {
        private int Eid;
        private string Title;
        private string Time;
        private string Date;
        private string Description;
        private string Bookedattendee;

        public int Eid1 { get => Eid; set => Eid = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Time1 { get => Time; set => Time = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Bookedattendee1 { get => Bookedattendee; set => Bookedattendee = value; }

        Dbconnection conn = new Dbconnection();
        public void add()
        {
            string query;
            query = "insert into Eventt(Title,Dates,Times,Descriptions,Attendeeid) values('" + Title1 + "','" + Date1 + "','" + Time1 + "','" + Description1 + "','" + Bookedattendee1 + "')";
            conn.Manipulate(query);

        }

        public DataTable load()
        {
            string query;
            query = "Select Firstname,Attendeeid,Statuss from Attendee where Statuss='NotBooked'";
            DataTable  dt=conn.Retrieve(query);
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


       

        public DataTable datagridload()
        {
            string query = "select Eventid,Title,Descriptions from Eventt";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public DataTable Eventload()
        {
            string query = "select e.Title,e.Times,e.Dates,e.Descriptions,a.Firstname from Eventt e,Attendee a where a.Attendeeid=e.Attendeeid and e.Eventid="+Eid1;
            DataTable dt=conn.Retrieve(query);
            return dt;
        }
        public void Delete()
        {
            string query = "Delete from Eventt where Eventid="+Eid1;
            conn.Manipulate(query);
        }

        public void Update()
        {
            string query="Update into Eventt where ";
            conn.Manipulate(query);
        }
    }
}
