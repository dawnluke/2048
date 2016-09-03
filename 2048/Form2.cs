using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = a[3, 0];
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = a[2, 2];
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = a[3, 2];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = a[0,0];
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = a[0, 1];
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Text = a[1, 0];
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = a[3, 0];
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = a[1, 1];
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = a[2, 1];
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = a[3, 1];
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = a[0, 2];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = a[1, 2];
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = a[0, 3];
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = a[1, 3];
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Text = a[2, 3];
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Text = a[3, 3];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
