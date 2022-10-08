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
    public partial class Form1 : Form
    {
        CrystalReport1 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            
        }

        private void button1_Click(object sender, EventArgs e) //movies button
        {
            this.Hide();
            movies_form f2 = new movies_form(); //this is the change, code for redirect  
            f2.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            tv_Shows f1 = new tv_Shows();
            f1.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr = new Form2();
            fr.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr = new Form3();
            fr.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr = new Form3();
            fr.ShowDialog();
        }
    }
}
