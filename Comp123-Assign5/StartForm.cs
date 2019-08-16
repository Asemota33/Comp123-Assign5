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
 * Description: This form prompts the user o add a new form or load an old one
 */
namespace Comp123_Assign5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event handler for the start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// Event handler for the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This event handler loads a saved text file and 
        /// sends the information to an instance of the products form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadOldFormButton_Click(object sender, EventArgs e)
        {
            // configure the file dialogue
            startFormOpenFileDialog.FileName = "Product.txt";
            startFormOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            startFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open file dialogue
            var result = startFormOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open your stream to read
                    using (StreamReader inputStream =
                        new StreamReader(File.Open(startFormOpenFileDialog.FileName, FileMode.Open)))
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

                        // After success open up the next page
                        this.Hide();
                        Program.productInfoForm.Show();
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
