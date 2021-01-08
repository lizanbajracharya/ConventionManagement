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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            Roombll room = new Roombll();
            DataTable dt = room.datagridloads();
            dgRoom.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                Roombll rooms = new Roombll();
                rooms.Location = txtLocation.Text;
                rooms.Capacity = txtCapacity.Text;
                rooms.Technical = txtTech.Text;
                rooms.add();
                MessageBox.Show("Successful");
                txtCapacity.Text = "";
                txtLocation.Text = "";
                txtTech.Text = "";
            }
            else if(btnAdd.Text=="Update")
            {
                Roombll rooms = new Roombll();
                rooms.Location = txtLocation.Text;
                rooms.Capacity = txtCapacity.Text;
                rooms.Technical = txtTech.Text;
                rooms.updateroom();
                MessageBox.Show("Successful");
                txtCapacity.Text = "";
                txtLocation.Text = "";
                txtTech.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Roombll room = new Roombll();

            int columnIndex = dgRoom.CurrentCell.ColumnIndex;
            int roomid = int.Parse(dgRoom.CurrentRow.Cells["id"].Value.ToString());
            room.Id = roomid;
            if (dgRoom.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = room.datagridloads();
                txtLocation.Text = dts.Rows[0][1].ToString();
                txtCapacity.Text = dts.Rows[0][2].ToString();
                txtTech.Text = dts.Rows[0][3].ToString();
                
                btnAdd.Text = "Update";
            }
           else if (dgRoom.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    room.Delete1();
                    DataTable dt = room.datagridloads();
                    dgRoom.DataSource = dt;
                }
            }
        }
    }
}
