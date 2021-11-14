using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String c = textBox1.Text;
            String b = textBox2.Text;

            if (c == "Nadeem" & b == "12")
            {
                Form2 a = new Form2();
                a.Show();
                
                
            }
            else {
                MessageBox.Show("Username or Password is incorrect");
            }

           
        }
    }
}
