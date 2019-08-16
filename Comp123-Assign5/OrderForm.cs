using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Michael Asemota
 * App Name: Dollar Computers
 * App Creation Date: 8/16/2019
 * Student #: 301052117
 * Description: This form displays the information selected from 
 * the selected form and shows the price before and after tax
 */
namespace Comp123_Assign5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cancel button eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Back button eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Print button eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing....", "Printing", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Displays information from previous form in the orderforms textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            decimal? cost = Program.product.cost;
            decimal? salesTax = (Program.product.cost * 13) / 100;
            decimal? totalCost = salesTax + cost;

            costDataLabel.Text = "$" + Convert.ToString(Math.Round((double)totalCost, 2));
            salesDataLabel.Text = "$" + Convert.ToString(Math.Round((double)salesTax, 2));
            priceDataLabel.Text = "$" + Convert.ToString(Math.Round((double)cost, 2));
            manufacturerDataLabel.Text = Program.product.manufacturer;
            modelDataLabel.Text = Program.product.model;
            memoryDataLabel.Text = Program.product.RAM_size;
            lcdSizeDataLabel.Text = Program.product.screensize;
            cpuBrandDataLabel.Text = Program.product.CPU_brand;
            cpuTypeDataLabel.Text = Program.product.CPU_type;
            cpuSpeedDataLabel.Text = Program.product.CPU_speed;
            cpuNumberDataLabel.Text = Program.product.CPU_number;
            conditionDataLabel.Text = Program.product.condition;
            osDataLabel.Text = Program.product.OS;
            platformDataLabel.Text = Program.product.platform;
            hddDataLabel.Text = Program.product.HDD_speed;
            gpuTypeDataLabel.Text = Program.product.GPU_Type;
            webcamDataLabel.Text = Program.product.webcam;

            // Determines what picture is about to be shown
            if (platformDataLabel.Text == "Laptop")
            {
                computerPictureBox.Load("Laptop.jpg");
            }
            else
            {
                computerPictureBox.Load("Desktop.jpg");
            }
        }
        /// <summary>
        /// Event handler for the about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// Event handler for the finish button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishButton_Click(object sender, EventArgs e)
        {
             var result = MessageBox.Show("Thank you for your business." + Environment.NewLine +
                "Your order will be processed in 7-10 business days. " + Environment.NewLine +
                "It was a pleasure doing business with you", "Order Processed", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
