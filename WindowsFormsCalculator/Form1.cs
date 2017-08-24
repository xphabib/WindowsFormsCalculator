using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //int x = Int32.Parse(TextBoxD1.Text);

            double a = Double.Parse(textFirstNumber.Text);
            double b = Double.Parse(textSecondNumber.Text);
            double c = a + b;

            textResult.Text = c.ToString();     


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textFirstNumber.Text);
            double b = Double.Parse(textSecondNumber.Text);
            double c = a - b;

            textResult.Text = c.ToString();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textFirstNumber.Text);
            double b = Double.Parse(textSecondNumber.Text);
            double c = a * b;

            textResult.Text = c.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textFirstNumber.Text);
            double b = Double.Parse(textSecondNumber.Text);
            double c = a / b;

            textResult.Text = c.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is developed by ABC Software Inc \n Copyright Habib ");
            FormAbout frm = new FormAbout();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
