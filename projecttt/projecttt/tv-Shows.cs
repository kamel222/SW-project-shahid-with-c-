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


namespace projecttt
{
    public partial class tv_Shows : Form
    {
        string ordb = "Data Source = orcl ;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public tv_Shows()
        {
            InitializeComponent();
        }
        private void tv_Shows_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "TVSHOW_DURATION";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("Show_title", comboBox2.Text);
            c.Parameters.Add("Show_Duration", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                textBox3.Text = c.Parameters["Show_Duration"].Value.ToString();

            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from tvShows where tvShow_ID=:tvShow_ID";
            c.Parameters.Add("movieID", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Tv Show Is Deleted Succesfully!");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update tvShows set  tvShow_Title=:title , tvsShow_releaseDate=:releasedate,tvsShow_Duration=:duration,tvsShow_Category=:category,tvsShow_Describtion=:describtion where tvShow_ID=:tvShow_ID)";
            c.Parameters.Add("tvShow_Title", comboBox2.Text);
            c.Parameters.Add("tvsShow_releaseDate", textBox2.Text);
            c.Parameters.Add("tvsShow_Duration", textBox3.Text);
            c.Parameters.Add("tvsShow_Category", textBox4.Text);
            c.Parameters.Add("tvsShow_Describtion", textBox5.Text);
            c.Parameters.Add("tvShow_ID", comboBox1.SelectedItem.ToString());
            int s = c.ExecuteNonQuery();
            if (s != -1)
            {
                MessageBox.Show("tv show is modified");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert into tvShows(tvShow_ID, tvShow_Title, tvsShow_releaseDate, tvsShow_Duration,tvsShow_Category,tvsShow_Describtion) values(:id,:title,:releasedate,:duration,:category,:describtion)";
            cmd.Parameters.Add("tvShow_ID", comboBox1.Text);
            cmd.Parameters.Add("tvShow_Title", comboBox2.Text);
            cmd.Parameters.Add("tvsShow_releaseDate", textBox2.Text);
            cmd.Parameters.Add(" tvsShow_Duration", textBox3.Text);
            cmd.Parameters.Add("tvsShow_Category", textBox4.Text);
            cmd.Parameters.Add("tvsShow_Describtion", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New tv show is added");

            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "SHOWTSTITLE";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("Tcategory", textBox4.Text);
            c.Parameters.Add("TStitle", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

        }
    }
}
