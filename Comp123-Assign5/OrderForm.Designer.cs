namespace Comp123_Assign5
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.platformLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.webcamTextBox = new System.Windows.Forms.TextBox();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.hddLabelTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.webcamLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxabel = new System.Windows.Forms.Label();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.finishButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.computerSpecsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // computerSpecsGroupBox
            // 
            this.computerSpecsGroupBox.Controls.Add(this.osTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.conditionTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.modelLabel);
            this.computerSpecsGroupBox.Controls.Add(this.modelTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.computerSpecsGroupBox.Controls.Add(this.lcdSizeTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.osLabel);
            this.computerSpecsGroupBox.Controls.Add(this.manufacturerLabel);
            this.computerSpecsGroupBox.Controls.Add(this.conditionLabel);
            this.computerSpecsGroupBox.Controls.Add(this.manufacturerTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.platformTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.platformLabel);
            this.computerSpecsGroupBox.Controls.Add(this.cpuNumberLabel);
            this.computerSpecsGroupBox.Controls.Add(this.cpuNumberTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.webcamTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.gpuTypeTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.computerSpecsGroupBox.Controls.Add(this.hddLabelTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.cpuSpeedTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.webcamLabel);
            this.computerSpecsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.computerSpecsGroupBox.Controls.Add(this.cpuTypeLabel);
            this.computerSpecsGroupBox.Controls.Add(this.hddLabel);
            this.computerSpecsGroupBox.Controls.Add(this.cpuTypeTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.cpuBrandLabel);
            this.computerSpecsGroupBox.Controls.Add(this.cpuBrandTextBox);
            this.computerSpecsGroupBox.Controls.Add(this.memoryLabel);
            this.computerSpecsGroupBox.Controls.Add(this.memoryTextBox);
            this.computerSpecsGroupBox.Location = new System.Drawing.Point(50, 150);
            this.computerSpecsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerSpecsGroupBox.Name = "computerSpecsGroupBox";
            this.computerSpecsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.computerSpecsGroupBox.Size = new System.Drawing.Size(694, 348);
            this.computerSpecsGroupBox.TabIndex = 3;
            this.computerSpecsGroupBox.TabStop = false;
            this.computerSpecsGroupBox.Text = "Computer Specs";
            // 
            // osTextBox
            // 
            this.osTextBox.Enabled = false;
            this.osTextBox.Location = new System.Drawing.Point(412, 66);
            this.osTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(269, 26);
            this.osTextBox.TabIndex = 7;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Enabled = false;
            this.conditionTextBox.Location = new System.Drawing.Point(415, 109);
            this.conditionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(267, 26);
            this.conditionTextBox.TabIndex = 8;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(122, 21);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Location = new System.Drawing.Point(224, 18);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(269, 26);
            this.modelTextBox.TabIndex = 9;
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.AutoSize = true;
            this.lcdSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeLabel.Location = new System.Drawing.Point(219, 188);
            this.lcdSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.lcdSizeLabel.TabIndex = 0;
            this.lcdSizeLabel.Text = "LCD Size";
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Enabled = false;
            this.lcdSizeTextBox.Location = new System.Drawing.Point(307, 179);
            this.lcdSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(96, 26);
            this.lcdSizeTextBox.TabIndex = 1;
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(338, 69);
            this.osLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(32, 20);
            this.osLabel.TabIndex = 3;
            this.osLabel.Text = "OS";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(4, 109);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.manufacturerLabel.TabIndex = 4;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(294, 109);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(76, 20);
            this.conditionLabel.TabIndex = 5;
            this.conditionLabel.Text = "Condition";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Enabled = false;
            this.manufacturerTextBox.Location = new System.Drawing.Point(126, 103);
            this.manufacturerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(120, 26);
            this.manufacturerTextBox.TabIndex = 10;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Enabled = false;
            this.platformTextBox.Location = new System.Drawing.Point(126, 54);
            this.platformTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(120, 26);
            this.platformTextBox.TabIndex = 11;
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(33, 57);
            this.platformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(68, 20);
            this.platformLabel.TabIndex = 6;
            this.platformLabel.Text = "Platform";
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(193, 238);
            this.cpuNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.cpuNumberLabel.TabIndex = 0;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Enabled = false;
            this.cpuNumberTextBox.Location = new System.Drawing.Point(307, 235);
            this.cpuNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuNumberTextBox.TabIndex = 1;
            // 
            // webcamTextBox
            // 
            this.webcamTextBox.Enabled = false;
            this.webcamTextBox.Location = new System.Drawing.Point(497, 182);
            this.webcamTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.webcamTextBox.Name = "webcamTextBox";
            this.webcamTextBox.Size = new System.Drawing.Size(184, 26);
            this.webcamTextBox.TabIndex = 1;
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Enabled = false;
            this.gpuTypeTextBox.Location = new System.Drawing.Point(497, 238);
            this.gpuTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.Size = new System.Drawing.Size(184, 26);
            this.gpuTypeTextBox.TabIndex = 1;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(202, 294);
            this.cpuSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.cpuSpeedLabel.TabIndex = 0;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // hddLabelTextBox
            // 
            this.hddLabelTextBox.Enabled = false;
            this.hddLabelTextBox.Location = new System.Drawing.Point(497, 291);
            this.hddLabelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hddLabelTextBox.Name = "hddLabelTextBox";
            this.hddLabelTextBox.Size = new System.Drawing.Size(184, 26);
            this.hddLabelTextBox.TabIndex = 1;
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Enabled = false;
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(307, 291);
            this.cpuSpeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuSpeedTextBox.TabIndex = 1;
            // 
            // webcamLabel
            // 
            this.webcamLabel.AutoSize = true;
            this.webcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamLabel.Location = new System.Drawing.Point(421, 185);
            this.webcamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.webcamLabel.Name = "webcamLabel";
            this.webcamLabel.Size = new System.Drawing.Size(72, 20);
            this.webcamLabel.TabIndex = 0;
            this.webcamLabel.Text = "Webcam";
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeLabel.Location = new System.Drawing.Point(411, 238);
            this.gpuTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.gpuTypeLabel.TabIndex = 0;
            this.gpuTypeLabel.Text = "GPU Type";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeLabel.Location = new System.Drawing.Point(16, 294);
            this.cpuTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.cpuTypeLabel.TabIndex = 0;
            this.cpuTypeLabel.Text = "CPU Type";
            // 
            // hddLabel
            // 
            this.hddLabel.AutoSize = true;
            this.hddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddLabel.Location = new System.Drawing.Point(405, 294);
            this.hddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(88, 20);
            this.hddLabel.TabIndex = 0;
            this.hddLabel.Text = "HDD Label";
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Enabled = false;
            this.cpuTypeTextBox.Location = new System.Drawing.Point(100, 288);
            this.cpuTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(89, 26);
            this.cpuTypeTextBox.TabIndex = 1;
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(12, 238);
            this.cpuBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.cpuBrandLabel.TabIndex = 0;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Enabled = false;
            this.cpuBrandTextBox.Location = new System.Drawing.Point(100, 232);
            this.cpuBrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(89, 26);
            this.cpuBrandTextBox.TabIndex = 1;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(20, 182);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(65, 20);
            this.memoryLabel.TabIndex = 0;
            this.memoryLabel.Text = "Memory";
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Enabled = false;
            this.memoryTextBox.Location = new System.Drawing.Point(100, 176);
            this.memoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(89, 26);
            this.memoryTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(91, 21);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(166, 16);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(73, 26);
            this.priceTextBox.TabIndex = 1;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.computerPictureBox.Location = new System.Drawing.Point(38, 30);
            this.computerPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(186, 116);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 4;
            this.computerPictureBox.TabStop = false;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.totalCostLabel);
            this.priceGroupBox.Controls.Add(this.totalCostTextBox);
            this.priceGroupBox.Controls.Add(this.salesTaxabel);
            this.priceGroupBox.Controls.Add(this.salesTaxTextBox);
            this.priceGroupBox.Controls.Add(this.priceLabel);
            this.priceGroupBox.Controls.Add(this.priceTextBox);
            this.priceGroupBox.Controls.Add(this.shapeContainer1);
            this.priceGroupBox.Location = new System.Drawing.Point(309, 30);
            this.priceGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceGroupBox.Size = new System.Drawing.Size(437, 102);
            this.priceGroupBox.TabIndex = 5;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(277, 44);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(81, 20);
            this.totalCostLabel.TabIndex = 0;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Enabled = false;
            this.totalCostTextBox.Location = new System.Drawing.Point(362, 38);
            this.totalCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(73, 26);
            this.totalCostTextBox.TabIndex = 1;
            // 
            // salesTaxabel
            // 
            this.salesTaxabel.AutoSize = true;
            this.salesTaxabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxabel.Location = new System.Drawing.Point(20, 69);
            this.salesTaxabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salesTaxabel.Name = "salesTaxabel";
            this.salesTaxabel.Size = new System.Drawing.Size(124, 20);
            this.salesTaxabel.TabIndex = 0;
            this.salesTaxabel.Text = "Sales Tax(13%) ";
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Enabled = false;
            this.salesTaxTextBox.Location = new System.Drawing.Point(166, 66);
            this.salesTaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.Size = new System.Drawing.Size(73, 26);
            this.salesTaxTextBox.TabIndex = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 21);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(433, 79);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 265;
            this.lineShape1.X2 = 265;
            this.lineShape1.Y1 = -3;
            this.lineShape1.Y2 = 71;
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(600, 509);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(157, 41);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(38, 509);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(157, 41);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(210, 509);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(157, 41);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.computerSpecsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computers";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.computerSpecsGroupBox.ResumeLayout(false);
            this.computerSpecsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox computerSpecsGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.TextBox webcamTextBox;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TextBox hddLabelTextBox;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label salesTaxabel;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}