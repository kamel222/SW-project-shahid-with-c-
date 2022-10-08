using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecttt
{
    public partial class Form2 : Form
    {
        CrystalReport1 cr;
        public Form2()
        {
            InitializeComponent();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
