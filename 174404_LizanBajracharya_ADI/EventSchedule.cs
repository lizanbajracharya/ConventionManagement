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
    public partial class EventSchedule : Form
    {
        public EventSchedule()
        {
            InitializeComponent();
        }

        private void EventSchedule_Load(object sender, EventArgs e)
        {
            Eventbll events = new Eventbll();


            DataTable dts = events.datagridload();
            dgEvent.DataSource = dts;
           

        }
    }
}
