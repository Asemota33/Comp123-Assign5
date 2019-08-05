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

namespace Comp123_Assign5
{
 
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        private void productInfoForm_activated(object sender, EventArgs e)
        {

            productIdTextBox.Text = Convert.ToString(Program.product.productID);
            costTextBox.Text = Convert.ToString(Program.product.cost);
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
            //ram.Text = Program.productClass.ramType 
            //Program.productClass.displayType 
            // Program.productClass.opticalDrive 
            // Program.productClass.audioType 
            // Program.productClass.lan 
            // Program.productClass.wifi 
            // Program.productClass.width 
            //Program.productClass.height 
            // Program.productClass.weight 
            //Program.productClass.depth 
            // Program.productClass.mouseType 
            //Program.productClass.power 
            //Program.productClass.hddSpeed 
            // Program.productClass.resolution 
            //Program.productClass.cpuClass 
            if (productIdTextBox.Text != string.Empty)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

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
