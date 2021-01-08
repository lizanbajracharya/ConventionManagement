using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_LizanBajracharya_ADI
{
    class loginbll
    {
        private string Username;
        private string password;

        public string Username1 { get => Username; set => Username = value; }
        public string Password { get => password; set => password = value; }
        Dbconnection conn = new Dbconnection();

        public bool checkUser()
        {
            DataTable dt = null;
            string query;
            query = "Select Username,Passwrd from Users where Username='" + Username1 + "' and Passwrd='" + Password + "'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int usercheck()
        {
            DataTable dt = null;
            string query = "select count(Userid) from Users";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }

      public string usertype()
        {
            DataTable dt = null;
            string query = "select Usertype from Users where Username='"+Username+"'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt.Rows[0][0].ToString();
            
        }
       
    }
}
