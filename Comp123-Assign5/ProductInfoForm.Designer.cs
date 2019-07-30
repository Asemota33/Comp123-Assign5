namespace Comp123_Assign5
{
    partial class ProductInfoForm
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.platformLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.computerSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
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
            this.selectAnotherProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.computerSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
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
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.costTextBox);
            this.productInfoGroupBox.Controls.Add(this.osTextBox);
            this.productInfoGroupBox.Controls.Add(this.costLabel);
            this.productInfoGroupBox.Controls.Add(this.conditionTextBox);
            this.productInfoGroupBox.Controls.Add(this.label13);
            this.productInfoGroupBox.Controls.Add(this.modelTextBox);
            this.productInfoGroupBox.Controls.Add(this.osLabel);
            this.productInfoGroupBox.Controls.Add(this.manufacturerLabel);
            this.productInfoGroupBox.Controls.Add(this.conditionLabel);
            this.productInfoGroupBox.Controls.Add(this.manufacturerTextBox);
            this.productInfoGroupBox.Controls.Add(this.platformTextBox);
            this.productInfoGroupBox.Controls.Add(this.platformLabel);
            this.productInfoGroupBox.Controls.Add(this.productIdTextBox);
            this.productInfoGroupBox.Controls.Add(this.productIdLabel);
            this.productInfoGroupBox.Location = new System.Drawing.Point(28, 60);
            this.productInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.productInfoGroupBox.Size = new System.Drawing.Size(728, 152);
            this.productInfoGroupBox.TabIndex = 1;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Product Info";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(577, 31);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(96, 26);
            this.costTextBox.TabIndex = 1;
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(316, 68);
            this.osTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(357, 26);
            this.osTextBox.TabIndex = 1;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(498, 34);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(42, 20);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Cost";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(316, 31);
            this.conditionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(96, 26);
            this.conditionTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(251, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Model";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(316, 110);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(357, 26);
            this.modelTextBox.TabIndex = 1;
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(267, 68);
            this.osLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(32, 20);
            this.osLabel.TabIndex = 0;
            this.osLabel.Text = "OS";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(-5, 113);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.manufacturerLabel.TabIndex = 0;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(227, 34);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(76, 20);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "Condition";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(118, 110);
            this.manufacturerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(94, 26);
            this.manufacturerTextBox.TabIndex = 1;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(116, 68);
            this.platformTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(96, 26);
            this.platformTextBox.TabIndex = 1;
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(31, 68);
            this.platformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(68, 20);
            this.platformLabel.TabIndex = 0;
            this.platformLabel.Text = "Platform";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(116, 31);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(96, 26);
            this.productIdTextBox.TabIndex = 1;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.Location = new System.Drawing.Point(14, 34);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(85, 20);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "Product ID";
            // 
            // computerSpecsGroupBox
            // 
            this.computerSpecsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.computerSpecsGroupBox.Controls.Add(this.lcdSizeTextBox);
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
            this.computerSpecsGroupBox.Location = new System.Drawing.Point(28, 234);
            this.computerSpecsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerSpecsGroupBox.Name = "computerSpecsGroupBox";
            this.computerSpecsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.computerSpecsGroupBox.Size = new System.Drawing.Size(728, 205);
            this.computerSpecsGroupBox.TabIndex = 2;
            this.computerSpecsGroupBox.TabStop = false;
            this.computerSpecsGroupBox.Text = "Computer Specs";
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.AutoSize = true;
            this.lcdSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeLabel.Location = new System.Drawing.Point(240, 47);
            this.lcdSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.lcdSizeLabel.TabIndex = 0;
            this.lcdSizeLabel.Text = "LCD Size";
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(320, 44);
            this.lcdSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(96, 26);
            this.lcdSizeTextBox.TabIndex = 1;
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(214, 106);
            this.cpuNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.cpuNumberLabel.TabIndex = 0;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(320, 100);
            this.cpuNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuNumberTextBox.TabIndex = 1;
            // 
            // webcamTextBox
            // 
            this.webcamTextBox.Location = new System.Drawing.Point(524, 47);
            this.webcamTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.webcamTextBox.Name = "webcamTextBox";
            this.webcamTextBox.Size = new System.Drawing.Size(200, 26);
            this.webcamTextBox.TabIndex = 1;
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Location = new System.Drawing.Point(524, 97);
            this.gpuTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.Size = new System.Drawing.Size(200, 26);
            this.gpuTypeTextBox.TabIndex = 1;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(223, 156);
            this.cpuSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.cpuSpeedLabel.TabIndex = 0;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // hddLabelTextBox
            // 
            this.hddLabelTextBox.Location = new System.Drawing.Point(524, 153);
            this.hddLabelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hddLabelTextBox.Name = "hddLabelTextBox";
            this.hddLabelTextBox.Size = new System.Drawing.Size(200, 26);
            this.hddLabelTextBox.TabIndex = 1;
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(320, 153);
            this.cpuSpeedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuSpeedTextBox.TabIndex = 1;
            // 
            // webcamLabel
            // 
            this.webcamLabel.AutoSize = true;
            this.webcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamLabel.Location = new System.Drawing.Point(432, 47);
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
            this.gpuTypeLabel.Location = new System.Drawing.Point(432, 100);
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
            this.cpuTypeLabel.Location = new System.Drawing.Point(19, 156);
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
            this.hddLabel.Location = new System.Drawing.Point(432, 156);
            this.hddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(88, 20);
            this.hddLabel.TabIndex = 0;
            this.hddLabel.Text = "HDD Label";
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(107, 153);
            this.cpuTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuTypeTextBox.TabIndex = 1;
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(14, 106);
            this.cpuBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.cpuBrandLabel.TabIndex = 0;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(107, 103);
            this.cpuBrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(96, 26);
            this.cpuBrandTextBox.TabIndex = 1;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(34, 50);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(65, 20);
            this.memoryLabel.TabIndex = 0;
            this.memoryLabel.Text = "Memory";
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(107, 47);
            this.memoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(96, 26);
            this.memoryTextBox.TabIndex = 1;
            // 
            // selectAnotherProductButton
            // 
            this.selectAnotherProductButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectAnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAnotherProductButton.ForeColor = System.Drawing.Color.White;
            this.selectAnotherProductButton.Location = new System.Drawing.Point(339, 509);
            this.selectAnotherProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectAnotherProductButton.Name = "selectAnotherProductButton";
            this.selectAnotherProductButton.Size = new System.Drawing.Size(229, 41);
            this.selectAnotherProductButton.TabIndex = 5;
            this.selectAnotherProductButton.Text = "Select Another Product";
            this.selectAnotherProductButton.UseVisualStyleBackColor = false;
            this.selectAnotherProductButton.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(11, 509);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 41);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(599, 509);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(157, 41);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectAnotherProductButton);
            this.Controls.Add(this.computerSpecsGroupBox);
            this.Controls.Add(this.productInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.productInfoGroupBox.ResumeLayout(false);
            this.productInfoGroupBox.PerformLayout();
            this.computerSpecsGroupBox.ResumeLayout(false);
            this.computerSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.GroupBox computerSpecsGroupBox;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TextBox hddLabelTextBox;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.TextBox webcamTextBox;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Button selectAnotherProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}