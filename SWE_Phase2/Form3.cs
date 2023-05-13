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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = System.Convert.ToInt32(textBox1.Text) * 0.025;
            label4.Text = System.Convert.ToString(result);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
