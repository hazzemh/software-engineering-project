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
   
    public partial class Form5 : Form
    {
        CrystalReport3 CR2;
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport3();
        }
        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = CR2;
        }
    }
}
