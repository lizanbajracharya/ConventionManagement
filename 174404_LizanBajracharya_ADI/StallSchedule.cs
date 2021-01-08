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
    public partial class StallSchedule : Form
    {
        public StallSchedule()
        {
            InitializeComponent();
        }

        private void StallSchedule_Load(object sender, EventArgs e)
        {
            Stallbll stall = new Stallbll();
            DataTable dt = stall.datagridload();
            dgStall.DataSource = dt;
        }
    }
}
