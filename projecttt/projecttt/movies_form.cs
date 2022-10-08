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
    public partial class movies_form : Form
    {
        string ordb = "Data Source = orcl ;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public movies_form()
        {
            InitializeComponent();
        }

        private void movies_form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

       
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert into movies(movieID, movieTitle, movie_releaseDate, movieDuration, movieCategory, movieDescribtion) values (:id,:title,:releasedate,:duration,:category,:describtion)";
            cmd.Parameters.Add("movieID", comboBox1.Text);
            cmd.Parameters.Add("movieTitle", comboBox2.Text);
            cmd.Parameters.Add("movie_releaseDate", textBox2.Text);
            cmd.Parameters.Add("movieDuration", textBox3.Text);
            cmd.Parameters.Add("movieCategory", textBox4.Text);
            cmd.Parameters.Add("movieDescribtion", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New movie is added");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update movies set movieTitle=:title , movie_releaseDate=:releasedate,movieDuration=:duration,movieCategory=:category,movieDescribtion=:describtion where movieID=:movieID)";
            c.Parameters.Add("movieTitle", comboBox2.Text);
            c.Parameters.Add("movie_releaseDate", textBox2.Text);
            c.Parameters.Add("movieDuration", textBox3.Text);
            c.Parameters.Add("movieCategory", textBox4.Text);
            c.Parameters.Add("movieDescribtion", textBox5.Text);
            c.Parameters.Add("movieID", comboBox1.SelectedItem.ToString());
            int s = c.ExecuteNonQuery();
            if (s != -1)
            {
                MessageBox.Show("movie is modified");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from movies where movieID=:movieID";
            c.Parameters.Add("movieID", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Movie Is Deleted Succesfully!");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "VIEWDURATION";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("movie_Title", comboBox2.Text);
            c.Parameters.Add("movie_Duration", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                textBox3.Text = c.Parameters["movie_Duration"].Value.ToString();

            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "SHOWTITLE";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("categoryy", textBox4.Text);
            c.Parameters.Add("Mtitle", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            while(dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
  
}