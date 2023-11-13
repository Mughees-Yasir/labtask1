using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Q1._1
{
    public partial class Form1 : Form
    {
        int i,j,k,ft=1,c=0;
        int a=1,b=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            j = int.Parse(textBox1.Text);
            while (a <= j)
            {
                if (j % a == 0)
                {
                    c++;
                }
                i++;

            }
            if (c == 2)
            {
                textBox2.Text = "Number is prime";
            }
            else
            {
                textBox2.Text = "Not prime";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = int.Parse(textBox1.Text);
            for (int q=i; q>0;q--)
            {
                ft = ft * q;
            }
            textBox2.Text = ft.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            k= int.Parse(textBox1.Text);
            for (int q = k; q > 0; q--)
            {
                textBox2.Text = q.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }
    }
}
