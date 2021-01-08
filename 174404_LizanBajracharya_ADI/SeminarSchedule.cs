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
    public partial class SeminarSchedule : Form
    {
        public SeminarSchedule()
        {
            InitializeComponent();
        }

        private void SeminarSchedule_Load(object sender, EventArgs e)
        {
            Seminarbll sem = new Seminarbll();
            DataTable dt = sem.datagridload();
            dgSeminar.DataSource = dt;
        }
    }
}
