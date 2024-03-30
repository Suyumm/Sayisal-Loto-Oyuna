using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int s1, s2, s3, s4, s5, s6;
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            s1 = r.Next(1, 50);
            s2 = r.Next(1, 50);
            s3 = r.Next(1, 50);
            s4 = r.Next(1, 50);
            s5 = r.Next(1, 50);
            s6 = r.Next(1, 50);

            Form2 f2 = new Form2();
            f2.label1.Text = s1.ToString();
            f2.label2.Text = s2.ToString();
            f2.label3.Text = s3.ToString();
            f2.label4.Text = s4.ToString();
            f2.label5.Text = s5.ToString();
            f2.label6.Text = s6.ToString();

            this.Hide();
            f2.Show();
        }
    }
}
