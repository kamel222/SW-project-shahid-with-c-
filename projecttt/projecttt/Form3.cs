using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using CrystalDecisions.Shared;



namespace projecttt
{
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "Data Source=orcl;User Id=scott;Password=tiger;";
        string cmd = "";
        CrystalReport2 cr;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string cmd = @"select * from subAcc where mainaccid=:n";
            
            adapter = new OracleDataAdapter(cmd, con);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void Subscription_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, textBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
