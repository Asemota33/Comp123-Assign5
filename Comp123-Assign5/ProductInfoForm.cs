using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
 * selected from the database table in the selected form 
 */
namespace Comp123_Assign5
{
 
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the select abother product button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }
        /// <summary>
        /// Event handler for the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event handler for the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        /// <summary>
        /// Fills up the forms labels with information form the product object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productInfoForm_activated(object sender, EventArgs e)
        {

            productIdLabelData.Text = Convert.ToString(Program.product.productID);
            costLabelData.Text = "$" + Convert.ToString(Math.Round((decimal)Program.product.cost, 2));
            manufacturerLabelData.Text = Program.product.manufacturer;
            modelLabelData.Text = Program.product.model;
            memoryLabelData.Text = Program.product.RAM_size;
            lcdSizeLabelData.Text = Program.product.screensize;
            cpuBrandLabelData.Text = Program.product.CPU_brand;
            cpuTypeLabelData.Text = Program.product.CPU_type;
            cpuSpeedLabelData.Text = Program.product.CPU_speed;
            cpuNumberLabelData.Text = Program.product.CPU_number;
            conditionLabelData.Text = Program.product.condition;
            osLabelData.Text = Program.product.OS;
            platformLabelData.Text = Program.product.platform;
            hddLabelData.Text = Program.product.HDD_speed;
            gpuTypeLabelData.Text = Program.product.GPU_Type;
            webcamLabelData.Text = Program.product.webcam;
            
            if (productIdLabelData.Text != string.Empty)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        /// <summary>
        /// Event handler that saves the information on the form to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            productSaveFileDialog.FileName = "Product.txt";
            productSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open file dialog - Modal Form
            var result = productSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open file to write
                using (StreamWriter outputStream = new StreamWriter
                    (File.Open(productSaveFileDialog.FileName, FileMode.Create)))
                {
                    //writing stuff to file

                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.webcam);

                    //Close file
                    outputStream.Close();
                    //Dispose of memory
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Event handler that opens a file on the users 
        /// computer then displays its contents on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialogue
            productOpenFileDialog.FileName = "Product.txt";
            productOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open file dialogue
            var result = productOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open your stream to read
                    using (StreamReader inputStream =
                        new StreamReader(File.Open(productOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //reading stuff to file
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = Convert.ToDecimal(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.HDD_speed = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //Close file
                        inputStream.Close();
                        //Dispose of memory
                        inputStream.Dispose();

                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
