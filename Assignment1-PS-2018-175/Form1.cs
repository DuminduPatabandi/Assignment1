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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string account,message;
            double discount;
            double price,newPrice;


            price = int.Parse(txtPrice.Text);
            account = customerCombo.GetItemText(customerCombo.SelectedItem);

            switch(account)
            {
                case "SILVER":
                    discount = 0.2;
                    break;
                case "GOLD":
                    discount = 0.3;
                    break;
                case "PLATINUM":
                    discount = 0.5;
                    break;
                case "OTHER":
                    discount = 0.1;
                    break;
                default:
                    MessageBox.Show("Please select an Account type.","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    discount = 0;
                    break;

            }

           newPrice = price - price * discount;

           message = "Price of the item is Rs." + newPrice + " Discount is Rs." + discount * price;

           MessageBox.Show(message,"INFORMATION");



        }
    }
}
