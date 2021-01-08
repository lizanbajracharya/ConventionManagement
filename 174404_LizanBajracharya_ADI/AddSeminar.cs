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
    public partial class AddSeminar : Form
    {
        public AddSeminar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Seminarbll seminar = new Seminarbll();
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter title");
                txtTitle.Focus();
            }
            else if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter Duration");
                txtDuration.Focus();
            }
            else if(cmbPresenter.Text=="")
            {
                MessageBox.Show("Please select a value");
                cmbPresenter.Focus();
            }
            else if(cmbSize.Text=="")
            {
                MessageBox.Show("Please select a value");
                cmbSize.Focus();
            }
            
            else
            {
                for (int i = 0; i < clbAttendee.Items.Count; i++)
                {
                    if (clbAttendee.GetItemChecked(i))
                    {
                        seminar.Title1 = txtTitle.Text;
                        seminar.Date1 = dtpDate.Text;
                        seminar.Time1 = dtpTime.Text;
                        seminar.Presenter1 = cmbPresenter.SelectedValue.ToString();
                        seminar.Registered1 = clbAttendee.SelectedValue.ToString();
                        seminar.Size = cmbSize.Text;
                        seminar.Duration1 = txtDuration.Text;
                        seminar.add();
                        seminar.add2(int.Parse(cmbPresenter.SelectedValue.ToString()));
                        seminar.updatestatus();
                        seminar.updatesize();
                    }

                }
                MessageBox.Show("Sucessful");
                txtTitle.Text = "";
                txtDuration.Text = "";
                cmbPresenter.Text = "";
                cmbSize.Text = "";
                if (clbAttendee.CheckedIndices.Count > 0)
                {
                    clbAttendee.SetItemChecked(clbAttendee.CheckedIndices[0], false);
                }
            }
            Seminarbll sem = new Seminarbll();
            DataTable dts = sem.datagridload();
            dgSeminar.DataSource = dts;
            datadisplay();
        }

        private void datadisplay()
        {
            Seminarbll seminar = new Seminarbll();
            DataTable dtsss = seminar.Locationload();
            cmbSize.DataSource = dtsss;
            cmbSize.DisplayMember = "Locations";
            cmbSize.ValueMember = "id";


            DataTable dt = seminar.load();

            clbAttendee.DataSource = dt;
            clbAttendee.DisplayMember = "Firstname";
            clbAttendee.ValueMember = "Attendeeid";

            cmbPresenter.DataSource = dt;
            cmbPresenter.DisplayMember = "Firstname";
            cmbPresenter.ValueMember = "Attendeeid";

            DataTable dtt = seminar.Sizeload();
            cmbSize.DataSource = dtt;
            cmbSize.DisplayMember = "Capacity";
            cmbSize.ValueMember = "id";
        }

        private void AddSeminar_Load(object sender, EventArgs e)
        {
            Seminarbll sem = new Seminarbll();
            DataTable dts = sem.datagridload();
            dgSeminar.DataSource = dts;
            datadisplay();
            

        }

        private void dgSeminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seminarbll seminar = new Seminarbll();
            int columnIndex = dgSeminar.CurrentCell.ColumnIndex;
            int seminarid = int.Parse(dgSeminar.CurrentRow.Cells["eid"].Value.ToString());
            seminar.Id = seminarid;
            
            
            if (dgSeminar.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    seminar.Delete();
                    DataTable dt = seminar.datagridload();
                    dgSeminar.DataSource = dt;
                }
            }
        }
    }
}