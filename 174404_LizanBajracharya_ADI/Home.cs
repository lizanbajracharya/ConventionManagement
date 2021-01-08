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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void displayTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAttendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addattendee attendee = new Addattendee();
            attendee.ShowDialog();
        }

        private void addSeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSeminar seminar = new AddSeminar();
            seminar.ShowDialog();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.ShowDialog();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent events=new AddEvent();
            events.ShowDialog();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void displaySeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeminarSchedule sem = new SeminarSchedule();
            sem.ShowDialog();
        }

        private void viewEventScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventSchedule events=new EventSchedule();
            events.ShowDialog();
        }

        private void displayEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void addEventLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StallLocation stall = new StallLocation();
            stall.ShowDialog();
        }

        private void viewRoomAndStallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewEventLoctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void displayAttendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendeeschedule attendee = new Attendeeschedule();
            attendee.ShowDialog();
        }

        private void roomAndStallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStallToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addStallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStall stall = new AddStall();
            stall.ShowDialog();
        }

        private void stallScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StallSchedule stall = new StallSchedule();
            stall.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRegister admin = new AdminRegister();
            admin.ShowDialog();
        }
    }
}
