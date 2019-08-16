using Comp123_Assign5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
 * Description: This form displays the information 
 * from our database and allows the user to select which item to purchase.
 */
namespace Comp123_Assign5
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form closing event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Exit button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Next button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This event handler loads the product database with the products 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet1.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet1.products);


            using (var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }

            // Enables next button if a row is selected
            if (selectionTextBox.Text != string.Empty)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        /// <summary>
        /// This method formats the selected item in a textbox as well 
        /// as populates the product properties with information
        /// </summary>
        /// <returns></returns>
        public string ProductDataGridViewSelectedItem()
        {
            var rowIndex = dollarComputersDataGridView.CurrentCell.RowIndex;
            var currentRow = dollarComputersDataGridView.Rows[rowIndex];
            var cells = dollarComputersDataGridView.Rows[rowIndex].Cells;
            var cost = currentRow.Cells[1].Value.ToString();
            var costDecimal = Decimal.Parse(cost);

            cost = costDecimal.ToString("C2");

            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputString = manufacturer + " " + model + " " + cost;

            Program.product.platform = cells[(int)ProductField.PLATFORM].Value.ToString();
            Program.product.productID = (short)cells[(int)ProductField.PRODUCT_ID].Value;
            Program.product.cost = Convert.ToDecimal(cells[(int)ProductField.COST].Value.ToString());
            Program.product.manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            Program.product.model = cells[(int)ProductField.MODEL].Value.ToString();
            Program.product.RAM_size = cells[(int)ProductField.RAM_SIZE].Value.ToString();
            Program.product.screensize = cells[(int)ProductField.SCREEN_SIZE].Value.ToString();
            Program.product.CPU_brand = cells[(int)ProductField.CPU_BRAND].Value.ToString();
            Program.product.CPU_type = cells[(int)ProductField.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = cells[(int)ProductField.CPU_SPEED].Value.ToString();
            Program.product.CPU_number = cells[(int)ProductField.CPU_NUMBER].Value.ToString();
            Program.product.condition = cells[(int)ProductField.CONDITION].Value.ToString();
            Program.product.OS = cells[(int)ProductField.OS].Value.ToString();
            Program.product.HDD_speed = cells[(int)ProductField.HDD_SPEED].Value.ToString();
            Program.product.GPU_Type = cells[(int)ProductField.GPU_TYPE].Value.ToString();
            Program.product.webcam = cells[(int)ProductField.WEBCAM].Value.ToString();


            return outputString;
        }
        /// <summary>
        /// This method displays formated information inside a textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dollarComputersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectionTextBox.Text = ProductDataGridViewSelectedItem();

        }
    }
}
