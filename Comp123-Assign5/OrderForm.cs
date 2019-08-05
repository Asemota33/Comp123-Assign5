using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_Assign5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing....", "Printing", MessageBoxButtons.OK);
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            decimal? cost = Program.product.cost;
            decimal? salesTax = (Program.product.cost * 13) / 100;
            decimal? totalCost = salesTax + cost;

            totalCostTextBox.Text = Convert.ToString(totalCost);
            salesTaxTextBox.Text = Convert.ToString(salesTax);
            priceTextBox.Text = Convert.ToString(cost);
            manufacturerTextBox.Text = Program.product.manufacturer;
            modelTextBox.Text = Program.product.model;
            memoryTextBox.Text = Program.product.RAM_size;
            lcdSizeTextBox.Text = Program.product.screensize;
            cpuBrandTextBox.Text = Program.product.CPU_brand;
            cpuTypeTextBox.Text = Program.product.CPU_type;
            cpuSpeedTextBox.Text = Program.product.CPU_speed;
            cpuNumberTextBox.Text = Program.product.CPU_number;
            conditionTextBox.Text = Program.product.condition;
            osTextBox.Text = Program.product.OS;
            platformTextBox.Text = Program.product.platform;
            hddLabelTextBox.Text = Program.product.HDD_speed;
            gpuTypeTextBox.Text = Program.product.GPU_Type;
            webcamTextBox.Text = Program.product.webcam;

            if (platformTextBox.Text == "Laptop")
            {
                computerPictureBox.Load("Laptop.jpg");
            }
            else
            {
                computerPictureBox.Load("Desktop.jpg");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
             var result = MessageBox.Show("Thank you for your business," +
                " your order will be processed in 7-10 business days. It was a pleasure doing business with you", "Order Processed", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
