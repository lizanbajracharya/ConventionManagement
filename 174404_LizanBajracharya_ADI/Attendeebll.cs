using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class Attendeebll
    {
        private int id;
        private string firstname;
        private string Lastname;
        private string Email;
        private string Typeofticket;
        private string numberofdays;

        public int Id { get => id; set => id = value; }

        public string Email1 { get => Email; set => Email = value; }
        public string Typeofticket1 { get => Typeofticket; set => Typeofticket = value; }
        public string Numberofdays { get => numberofdays; set => numberofdays = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }

        Dbconnection conn = new Dbconnection();
        public void add()
        {
            string query;
            query = "insert into Attendee(Firstname,Lastname,Email,Numberofdays,Typeofticket,Statuss) values('" + Firstname + "','" + Lastname1 + "','" + Email1 + "','" + Numberofdays + "days','" + Typeofticket1 + "','NotBooked')";
            conn.Manipulate(query);
        }

        public DataTable datagridload()
        {
            string query = "select Attendeeid,Firstname,Lastname,Numberofdays from Attendee";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void Delete()
        {
            string query = "Delete from Attendee where Attendeeid=" + Id;
            string query1 = "Delete from Audience where Attendeeid=" + Id;
            string query2 = "Delete from Seminar where Attendeeid=" + Id;
            string query3 = "Delete from Stall where Attendeeid="+Id;
            string query4 = "Delete from Eventt where Attendeeid=" + Id;
            conn.Manipulate(query1);
            conn.Manipulate(query3);
            conn.Manipulate(query2);
            conn.Manipulate(query4);
            conn.Manipulate(query);
        }

        public DataTable loaddata()
        {
            string query = "select Firstname,Lastname,Email,Typeofticket,Numberofdays from Attendee where Attendeeid="+id;
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public void update()
        {
            string query = "Update Attendee set Firstname='"+Firstname+"',Lastname='"+Lastname+"',Email='"+Email+"',Typeofticket='"+Typeofticket+"',Numberofdays='"+Numberofdays+"' where Attendeeid='"+Id+"'";
            conn.Manipulate(query);
        }
    }
}
