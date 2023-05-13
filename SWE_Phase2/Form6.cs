using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Phase2
{
    public partial class Form6 : Form
    {
        CrystalReport2 cs;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cs = new CrystalReport2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cs;
        }
    }
}
