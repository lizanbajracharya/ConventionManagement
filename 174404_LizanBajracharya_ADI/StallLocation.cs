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
    public partial class StallLocation : Form
    {
        public StallLocation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "")
            {
                MessageBox.Show("Please enter a value");
            }
            else if (txtCapacity.Text == "")
            {
                MessageBox.Show("Please enter a value");
            }
            else if (txtTech.Text == "")
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                if (btnAdd.Text == "Add")
                {
                    Roombll rooms = new Roombll();
                    rooms.Location = txtLocation.Text;
                    rooms.Capacity = txtCapacity.Text;
                    rooms.Technical = txtTech.Text;
                    rooms.add2();
                    MessageBox.Show("Sucessful");
                    txtLocation.Text = "";
                    txtCapacity.Text = "";
                    txtTech.Text = "";
                    Roombll room = new Roombll();
                    DataTable dt = room.datagridload();
                    dgStall.DataSource = dt;
                }
                else
                {
                    Roombll rooms = new Roombll();
                    rooms.Location = txtLocation.Text;
                    rooms.Capacity = txtCapacity.Text;
                    rooms.Technical = txtTech.Text;
                    rooms.updatestall();
                    btnAdd.Text = "Add";
                    MessageBox.Show("Updated");
                    txtLocation.Text = "";
                    txtCapacity.Text = "";
                    txtTech.Text = "";
                    Roombll room = new Roombll();
                    DataTable dt = room.datagridload();
                    dgStall.DataSource = dt;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dgStall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Roombll room = new Roombll();

            int columnIndex = dgStall.CurrentCell.ColumnIndex;
            int seminarid = int.Parse(dgStall.CurrentRow.Cells["id"].Value.ToString());
            room.Id = seminarid;
            if (dgStall.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = room.datagridloads();
                txtLocation.Text = dts.Rows[0][1].ToString();
                txtCapacity.Text = dts.Rows[0][2].ToString();
                txtTech.Text = dts.Rows[0][3].ToString();

                btnAdd.Text = "Update";
            }
            else if (dgStall.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    room.Delete();
                    DataTable dt = room.datagridload();
                    dgStall.DataSource = dt;
                }
            }
        }

        private void StallLocation_Load(object sender, EventArgs e)
        {
            Roombll room = new Roombll();
            DataTable dt = room.datagridload();
            dgStall.DataSource = dt;
        }
    }
}
