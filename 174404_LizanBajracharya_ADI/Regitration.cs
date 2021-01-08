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
    public partial class Regitration : Form
    {
        public Regitration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            useraddbll user = new useraddbll();

            string Firstname = txtFirst.Text;
            string Lastname = txtLast.Text;
            string Address = txtAddrss.Text;
            string Email = txtEmail.Text;
            string phone = txtPhone.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Gender;

            user.FirstName1 = Firstname;
            user.LastName1 = Lastname;
            user.Address1 = Address;
            user.Email1 = Email;
            user.Password1 = Password;
            user.PhoneNo1= phone;
            user.Username1 = Username;

            if (Firstname == "")
            {
                MessageBox.Show("Please input First name");
            }
            else if (Lastname == "")
            {
                MessageBox.Show("Please input Last name");
            }
            else if (Address == "")
            {
                MessageBox.Show("Please input Address");
            }
            else if (Email == "")
            {
                MessageBox.Show("Please input Email");
            }
            else if (phone == "")
            {
                MessageBox.Show("Please input Phone number");
            }
            else if (Username == "")
            {
                MessageBox.Show("Please input Username");
            }
            else if (Password == "")
            {
                MessageBox.Show("Please input Password");
            }

            else
            {
                if (rdoMale.Checked == true)
                {
                    Gender = "M";
                }
                else if (rdoFemale.Checked == true)
                {
                    Gender = "F";
                }
                else
                {
                    MessageBox.Show("Please select gender");
                    return;
                }
                user.Gender1 = Gender;

                DataTable dt = user.UsernameEntry();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exist");
                    txtUsername.Focus();
                }
                else
                {
                    user.Addnormal();
                    MessageBox.Show("Inserted");
                    DataClear();
                }


            }
            
        }
        private void DataClear()
        {
            txtFirst.Text = txtLast.Text = txtAddrss.Text = txtEmail.Text = txtPassword.Text = txtPhone.Text = txtUsername.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
