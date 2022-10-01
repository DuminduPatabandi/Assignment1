using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_PS_2018_175
{
    public partial class Form2 : Form
    {
        double BMI;
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, height;

            weight = double.Parse(txtWeight.Text);
            height = double.Parse(txtHeight.Text);

            BMI = weight / (height * height);

            MessageBox.Show("Your BMI Value is " + BMI, "Information");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);

            if(BMI > 25)
            {
                txtInfo.Text = "Take an initial blood screen test immediately";
            }
            else if(radioYes.Checked)
            {
                txtInfo.Text = "Take a blood screen test every year";
            }
            else if (age > 25)
            {
                txtInfo.Text = "Take an initial blood screen test per every three years";
            }
            else
            {
                txtInfo.Text = "You do not have to have a blood screen test";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            txtAge.Clear();
            txtInfo.Clear();
        }
    }
}
