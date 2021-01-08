using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class Seminarbll
    {
        private int id;
        private string Title;
        private string Date;
        private string Time;
        private string Presenter;
        private string size;
        private string Duration;
        private string Registered;

        public string Registered1 { get => Registered; set => Registered = value; }
        public int Id { get => id; set => id = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string Time1 { get => Time; set => Time = value; }
        public string Presenter1 { get => Presenter; set => Presenter = value; }
        public string Size { get => size; set => size = value; }
        public string Duration1 { get => Duration; set => Duration = value; }

        Dbconnection conn = new Dbconnection();

        public void add()
        {
            string query;
            query = "insert into Seminar(Title,Dateandtime,times,Attendeeid,Sizeofroom,Duration) values('" +Title+ "','" + Date + "','" + Time + "','" + Presenter + "','" + Size + "','" + Duration + "')";
            conn.Manipulate(query);            
        }
            
        public void add2(int aid)
        {
            string query1 = "insert into Audience(Attendeeid,Seminarid) values('" + aid + "','" + semid() + "')";
            conn.Manipulate(query1);
        }

        public int semid()
        {
            string query = "select Seminarid from Seminar order by Seminarid desc";
            return int.Parse(conn.Retrieve(query).Rows[0][0].ToString());
        }

       
        public string attendeid()
        {
                string query = "select Attendeeid from Attendee where Statuss='NotBooked'";
                DataTable dt = conn.Retrieve(query);
                return dt.Rows[0][0].ToString();
        }
        public string locationid()
        {
            string query = "select id from RoomStallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt.Rows[0][0].ToString();
        }

        public void updatesize()
        {
            string query="Update RoomStallLocation set Statuss='Booked' where Statuss='Unbooked' and id="+locationid();
            conn.Manipulate(query);
        }

        public DataTable Locationload()
        {
            string query = "Select id,Locations,Statuss from RoomStallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void updatestatus()
        {
            string query = "Update Attendee set Statuss='Booked' where Statuss='NotBooked' and Attendeeid='"+attendeid()+"'";
            conn.Manipulate(query);
        }


        public DataTable load()
        {
            string query;
            query = "Select Firstname,Attendeeid,Statuss from Attendee where Statuss='NotBooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

      

       
       
       

        public DataTable datagridload()
        {
            string query = "select s.Seminarid,s.Title,a.Firstname,s.Duration,ac.Audienceid from Seminar s,Attendee a,Audience ac where s.Seminarid=ac.Seminarid and a.Attendeeid=ac.Attendeeid";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public DataTable Sizeload()
        {
            string query = "Select id,Capacity,Statuss from RoomStallLocation where Statuss='Unbooked'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void Delete()
        {
            string query = "Delete from Seminar where Seminarid=" + Id;
            string query1 = "Delete from Audience where Seminarid=" + Id;
            conn.Manipulate(query1);
            conn.Manipulate(query);
        }

        public DataTable seminarload()
        {
            string query = "select s.Title,s.Times,s.Dateandtime,s.Sizeofroom,a.Firstname from Seminar s,Attendee a where a.Attendeeid=s.Attendeeid and s.Seminarid=" + Id;
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

    }
}
