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
    public partial class Addattendee : Form
    {
        public Addattendee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "")
            {
                MessageBox.Show("Please enter a firstname");
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Please enter a lastname");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter a Email");
            }
            else if (txtNumber.Text == "")
            {
                MessageBox.Show("Please enter a Number of days");
            }
            else if (cmbTicket.Text == "")
            {
                MessageBox.Show("Please select a type of ticket");
            }
            else
            {
                if (btnAdd.Text == "Add")
                {
                    Attendeebll attendee = new Attendeebll();

                    attendee.Firstname = txtFirst.Text;
                    attendee.Lastname1 = txtLast.Text;
                    attendee.Numberofdays = txtNumber.Text;
                    attendee.Email1 = txtEmail.Text;
                    attendee.Typeofticket1 = cmbTicket.Text;
                    attendee.add();
                    MessageBox.Show("Successful");
                    txtFirst.Text = txtLast.Text = txtEmail.Text = txtNumber.Text = "";
                    Attendeebll attende = new Attendeebll();
                    DataTable dt = attende.datagridload();
                    dgAttendee.DataSource = dt;
                }
                else if(btnAdd.Text=="Update")
                {
                    Attendeebll attendee = new Attendeebll();
                    attendee.update();
                    MessageBox.Show("Updated");
                    btnAdd.Text = "Add";
                    txtFirst.Text = txtLast.Text = txtEmail.Text = txtNumber.Text = "";
                    Attendeebll attende = new Attendeebll();
                    DataTable dt = attende.datagridload();
                    dgAttendee.DataSource = dt;
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void Addattendee_Load(object sender, EventArgs e)
        {
            Attendeebll attende = new Attendeebll();
            DataTable dt = attende.datagridload();
            dgAttendee.DataSource = dt;
        }

        private void dgAttendee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAttendee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Attendeebll attendee = new Attendeebll();

            int columnIndex = dgAttendee.CurrentCell.ColumnIndex;
            int attendeid = int.Parse(dgAttendee.CurrentRow.Cells["aid"].Value.ToString());
            attendee.Id = attendeid;

            if (dgAttendee.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = attendee.loaddata();
                txtFirst.Text = dts.Rows[0][0].ToString();
                txtLast.Text = dts.Rows[0][1].ToString();
                txtEmail.Text = dts.Rows[0][2].ToString();
                cmbTicket.Text = dts.Rows[0][3].ToString();
                txtNumber.Text = dts.Rows[0][4].ToString();

                btnAdd.Text = "Update";
            }
            else if (dgAttendee.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    attendee.Delete();
                    DataTable dt = attendee.datagridload();
                    dgAttendee.DataSource = dt;
                }
            }
        }
    }
}
