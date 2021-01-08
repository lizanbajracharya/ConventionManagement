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
    public partial class Userhome : Form
    {
        public Userhome()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendeeschedule attendee = new Attendeeschedule();
            attendee.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void viewSeminarScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeminarSchedule seminar = new SeminarSchedule();
            seminar.ShowDialog();
        }

        private void viewEventScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventSchedule events = new EventSchedule();
            events.ShowDialog();
        }

        private void viewStallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StallSchedule stall = new StallSchedule();
            stall.ShowDialog();
        }
    }
}
