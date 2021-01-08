using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class useraddbll
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string Email;
        private string PhoneNo;
        private string Gender;
        private string Username;
        private string Password;
        private int ID;
        private string Usertype;

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PhoneNo1 { get => PhoneNo; set => PhoneNo = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Usertype1 { get => Usertype; set => Usertype = value; }
        Dbconnection conn = new Dbconnection();

        public DataTable UsernameEntry()
        {
            DataTable dt = null;
            string query = "select Username from Users where Username='" + Username1 + "'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }

        public void Addnormal()
        {
            string query;
            query = "insert into Users(Firstname,Lastname,Addrss,Phone,Email,Gender,Username,Passwrd,UserType)values('" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + Email + "','" + Gender + "','" + Username + "','" + Password + "','Users')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AdminUpdate()
        {
            string query;
            query = "Update Users set Firstname='" + FirstName + "',Lastname='" + LastName + "',Addrss='" + Address + "',Phone='" + PhoneNo + "',Email='" + Email + "',Gender='" + Gender + "',Username='" + Username + "',Passwrd='" + Password + "',UserType='"+Usertype+"' where Userid=" + ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable Userload()
        {
            DataTable dt = null;
            string query;
            query = "Select Userid,Firstname,Lastname,Addrss,Email,Phone,Gender,Username,UserType from Users ";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public DataTable UserUpdateadmin()
        {
            DataTable dt = null;
            string query;
            query = "select Firstname,Lastname,Addrss,Phone,Email,Username,Passwrd,Gender from Users where UserID=" + ID;
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public void Delete()
        {
            string query;
            query = "Delete from Users where UserID=" + ID;

            try
            {

                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Add()
        {
            string query;
            query = "insert into Users(Firstname,Lastname,Addrss,Phone,Email,Gender,Username,Passwrd,UserType)values('" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + Email + "','" + Gender + "','" + Username + "','" + Password + "','" + Usertype + "')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
