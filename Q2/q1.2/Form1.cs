using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace q1._2
{
    public partial class Form1 : Form
    {
        string a, b, c, d;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            d = textBox3.Text;
            c = textBox4.Text;

            MessageBox.Show("Name: "+a+"  Email: "+b+"  PhoneNo: "+c+"  CityName: "+d,"Conform",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
