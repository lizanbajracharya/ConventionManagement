using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174404_LizanBajracharya_ADI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* string Username = txtUsername.Text;
            string Password = txtPassword.Text;*/

           
            loginbll login = new loginbll();
            login.Username1 = txtUsername.Text;
            login.Password = txtPassword.Text;
            bool isValiduser = login.checkUser();


            

            if (txtUsername.Text=="")
            {
                MessageBox.Show("Username Empty");
                txtUsername.Focus();
            }
            else if(txtPassword.Text=="")
            {
                MessageBox.Show("Password Empty");
                txtPassword.Focus();
            }

            
            else if (isValiduser)
            {
                string Usertype = login.usertype();
                if (Usertype=="Admin\t")
                {
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }

                else if(Usertype=="Users")
                {
                    this.Hide();
                    Userhome home1 = new Userhome();
                    home1.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                
            }
            else
            {
                
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginbll login = new loginbll();
            int usercheck = login.usercheck();
            if (usercheck == 0)
            {
                AdminRegister user = new AdminRegister();
                user.ShowDialog();
            }
            else
            {
                Regitration register = new Regitration();
                register.ShowDialog();
            }
            
        }
    }
}
