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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hazem;";
        OracleConnection conn;

        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 15000);
            int randNum = myObject.Next(1, 15000);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"begin
                                insert into Donations values(:donid,:amount,:Donationtype,:Phoneno);
                                insert into doners values(:DonerID,:nameoncard,:creditcardnumber,:expirationdate,:cvv,:paymenttype);
                                 end;";

            cmd.Parameters.Add("donid", ranNum);
            cmd.Parameters.Add("amount", textBox1.Text);
            cmd.Parameters.Add("DonationType", cmb_1.SelectedItem);
            cmd.Parameters.Add("phoneno", textBox6.Text);
            cmd.Parameters.Add("DonerID", randNum);
            cmd.Parameters.Add("nameoncard", textBox5.Text);
            cmd.Parameters.Add("creditcardnumber", textBox2.Text);
            cmd.Parameters.Add("expirationdate",dateTimePicker1.Text);
            cmd.Parameters.Add("cvv", textBox4.Text);
            if (radioButton1.Checked)
            {
               cmd.Parameters.Add("paymenttype", radioButton1.Text);
            }
            else if(radioButton2.Checked)
            {
               cmd.Parameters.Add("paymenttype", radioButton2.Text);
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Donation has been transfered Sucessfully !");
            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel4.Visible = true;
                button4.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                panel2.Visible = true;
                button1.Visible = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 15000);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"begin
                                insert into Donations values(:donid,:amount,:Donationtype,:Phoneno);
                                insert into userinfo values(:address,:mobno,:notes);       
                                 end;";
            cmd.Parameters.Add("donid", ranNum);
            cmd.Parameters.Add("amount", textBox1.Text);
            cmd.Parameters.Add("DonationType", cmb_1.SelectedItem);
            cmd.Parameters.Add("Phoneno", textBox7.Text);
            cmd.Parameters.Add("address", textBox8.Text);
            cmd.Parameters.Add("mobno", textBox7.Text);
            cmd.Parameters.Add("notes", textBox3.Text);
            //if (radioButton1.Checked)
            //{
            //    cmd.Parameters.Add("paymenttype", radioButton1.Text);
            //}
            //else if (radioButton2.Checked)
            //{
            //    cmd.Parameters.Add("paymenttype", radioButton2.Text);
            //}
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your information has been saved Sucessfully !");
            conn.Close();
        }
    }
}