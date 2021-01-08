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
    public partial class AddStall : Form
    {
        public AddStall()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void datadisplay()
        {
            Stallbll stall = new Stallbll();
            DataTable dt = stall.load();
            cmbAttendee.DataSource = dt;
            cmbAttendee.DisplayMember = "Firstname";
            cmbAttendee.ValueMember = "Attendeeid";


            DataTable dtt = stall.Sizeload();
            cmbSize.DataSource = dtt;
            cmbSize.DisplayMember = "Capacity";
            cmbSize.ValueMember = "Locationid";

            DataTable dttss = stall.Locationload();
            cmbLocation.DataSource = dttss;
            cmbLocation.DisplayMember = "Locations";
            cmbLocation.ValueMember = "Locationid";
        }
        private void AddStall_Load(object sender, EventArgs e)
        {
            Stallbll stalls = new Stallbll();
            DataTable dtts = stalls.datagridload();
            dgStall.DataSource = dtts;
            datadisplay();
           
        }

        private void cmbStall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Stallbll stall = new Stallbll();
            if (txtDay.Text == "")
            {
                MessageBox.Show("Please Enter day");
                txtDay.Focus();
            }
            else if (txtStall.Text == "")
            {
                MessageBox.Show("Please Stall Type");
                txtStall.Focus();
            }
            else
            {
                stall.Location1 = cmbLocation.SelectedValue.ToString();
                stall.Size1 = cmbSize.SelectedValue.ToString();
                stall.Attendee1 = cmbAttendee.SelectedValue.ToString();
                stall.Day1 = txtDay.Text;
                stall.Type = txtStall.Text;
                stall.add();
                stall.updatestatus();
                stall.updatesize();
                MessageBox.Show("Successful");
                txtDay.Text = "";
                txtStall.Text = "";
                datadisplay();
            }
        }

        private void dgStall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Stallbll stall = new Stallbll();

            int columnIndex = dgStall.CurrentCell.ColumnIndex;
            int seminarid = int.Parse(dgStall.CurrentRow.Cells["sid"].Value.ToString());
            stall.Id = seminarid;
            
          if (dgStall.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    stall.Delete();
                    DataTable dt = stall.datagridload();
                    dgStall.DataSource = dt;
                }
            }
        }
    }
}
