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
    public partial class Attendeeschedule : Form
    {
        public Attendeeschedule()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Attendeeschedule_Load(object sender, EventArgs e)
        {
            Attendeebll attendee = new Attendeebll();
            DataTable dt = attendee.datagridload();
            dgAttendee.DataSource = dt;
        }
    }
}
