using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Phase2
{
    public partial class Form4 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder command;
        DataSet ds;
        
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=hr;Password=hazem;";
            string cmdstr = @"select * from Donations
                            where phoneno = :phone";
            adapter = new OracleDataAdapter(cmdstr , constr);
            adapter.SelectCommand.Parameters.Add("phone", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new OracleCommandBuilder(adapter);
            adapter.UpdateCommand = command.GetUpdateCommand();
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes Saved");
        }

        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
