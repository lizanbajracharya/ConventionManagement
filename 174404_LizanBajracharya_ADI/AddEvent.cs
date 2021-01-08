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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Eventbll events = new Eventbll();
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter a title");
                txtTitle.Focus();
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter a description");
                txtDescription.Focus();
            }
            else if (clbAttendee.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please selecet a value");
            }
            else
            {
                for (int i = 0; i < clbAttendee.Items.Count; i++)
                {
                    if (clbAttendee.GetItemChecked(i))
                    {
                        
                        string title = txtTitle.Text;
                        events.Title1 = title;
                        events.Time1 = dtpTime.Text;
                        events.Date1 = dtpDate.Text;
                        
                        events.Bookedattendee1 = clbAttendee.SelectedValue.ToString();
                        events.Description1 = txtDescription.Text;

                        events.add();
                        events.updatestatus();

                       
                        MessageBox.Show("Sucessful");
                        txtTitle.Text = "";
                        txtDescription.Text = "";
                        if (clbAttendee.CheckedIndices.Count > 0)
                        {
                            clbAttendee.SetItemChecked(clbAttendee.CheckedIndices[0], false);
                        }
                    }
                }
            }
            Datadisplay();
        }

        private void Datadisplay()
        {
            Eventbll events = new Eventbll();
            DataTable dt = events.load();

            clbAttendee.DataSource = dt;
            clbAttendee.DisplayMember = "Firstname";
            clbAttendee.ValueMember = "Attendeeid";

        }
        private void AddEvent_Load(object sender, EventArgs e)
        {
            Eventbll events = new Eventbll();
           
           
            DataTable dts = events.datagridload();
            dgEvent.DataSource = dts;
            Datadisplay();
            
        }

        private void dgEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Eventbll events = new Eventbll();
            int columnIndex = dgEvent.CurrentCell.ColumnIndex;
            int eventid = int.Parse(dgEvent.CurrentRow.Cells["eid"].Value.ToString());
            events.Eid1 = eventid;
            if (dgEvent.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = events.Eventload();
                txtTitle.Text = dts.Rows[0][0].ToString();
                dtpDate.Text = dts.Rows[0][1].ToString();
                dtpTime.Text = dts.Rows[0][2].ToString();
                txtDescription.Text = dts.Rows[0][3].ToString();
                clbAttendee.Text = dts.Rows[0][4].ToString();
                Add.Text = "Update";
            }
            else if (dgEvent.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    events.Delete();
                    DataTable dts = events.datagridload();
                    dgEvent.DataSource = dts;
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
