namespace Comp123_Assign5
{
    partial class SelectForm
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
            this.components = new System.ComponentModel.Container();
            this.hardwareSelectionLabel = new System.Windows.Forms.Label();
            this.dollarComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarComputersDataSet1 = new Comp123_Assign5.DollarComputersDataSet1();
            this.dollarComputersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarComputersDataSet = new Comp123_Assign5.DollarComputersDataSet();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.productsTableAdapter = new Comp123_Assign5.DollarComputersDataSet1TableAdapters.productsTableAdapter();
            this.selectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwareSelectionLabel
            // 
            this.hardwareSelectionLabel.AutoSize = true;
            this.hardwareSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareSelectionLabel.Location = new System.Drawing.Point(6, 19);
            this.hardwareSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hardwareSelectionLabel.Name = "hardwareSelectionLabel";
            this.hardwareSelectionLabel.Size = new System.Drawing.Size(536, 25);
            this.hardwareSelectionLabel.TabIndex = 0;
            this.hardwareSelectionLabel.Text = "You are about to make a computer hardware selection ";
            // 
            // dollarComputersDataGridView
            // 
            this.dollarComputersDataGridView.AllowUserToAddRows = false;
            this.dollarComputersDataGridView.AllowUserToDeleteRows = false;
            this.dollarComputersDataGridView.AllowUserToResizeColumns = false;
            this.dollarComputersDataGridView.AllowUserToResizeRows = false;
            this.dollarComputersDataGridView.AutoGenerateColumns = false;
            this.dollarComputersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dollarComputersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dollarComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dollarComputersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
            this.dollarComputersDataGridView.DataSource = this.productBindingSource;
            this.dollarComputersDataGridView.Location = new System.Drawing.Point(8, 58);
            this.dollarComputersDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dollarComputersDataGridView.MultiSelect = false;
            this.dollarComputersDataGridView.Name = "dollarComputersDataGridView";
            this.dollarComputersDataGridView.ReadOnly = true;
            this.dollarComputersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dollarComputersDataGridView.Size = new System.Drawing.Size(768, 349);
            this.dollarComputersDataGridView.TabIndex = 1;
            this.dollarComputersDataGridView.SelectionChanged += new System.EventHandler(this.dollarComputersDataGridView_SelectionChanged);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.costDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.costDataGridViewTextBoxColumn.Width = 50;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.manufacturerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.manufacturerDataGridViewTextBoxColumn.Width = 126;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modelDataGridViewTextBoxColumn.Width = 69;
            // 
            // rAMtypeDataGridViewTextBoxColumn
            // 
            this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
            this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rAMtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rAMtypeDataGridViewTextBoxColumn.Width = 103;
            // 
            // rAMsizeDataGridViewTextBoxColumn
            // 
            this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
            this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMsizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rAMsizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rAMsizeDataGridViewTextBoxColumn.Width = 101;
            // 
            // displaytypeDataGridViewTextBoxColumn
            // 
            this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.HeaderText = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
            this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.displaytypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.displaytypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.displaytypeDataGridViewTextBoxColumn.Width = 109;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.screensizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.screensizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.screensizeDataGridViewTextBoxColumn.Width = 107;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "resolution";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resolutionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.resolutionDataGridViewTextBoxColumn.Width = 98;
            // 
            // cPUClassDataGridViewTextBoxColumn
            // 
            this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
            this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUClassDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUClassDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUClassDataGridViewTextBoxColumn.Width = 109;
            // 
            // cPUbrandDataGridViewTextBoxColumn
            // 
            this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
            this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUbrandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUbrandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUbrandDataGridViewTextBoxColumn.Width = 113;
            // 
            // cPUtypeDataGridViewTextBoxColumn
            // 
            this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
            this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUtypeDataGridViewTextBoxColumn.Width = 99;
            // 
            // cPUspeedDataGridViewTextBoxColumn
            // 
            this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
            this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUspeedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUspeedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUspeedDataGridViewTextBoxColumn.Width = 117;
            // 
            // cPUnumberDataGridViewTextBoxColumn
            // 
            this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
            this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUnumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUnumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUnumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conditionDataGridViewTextBoxColumn.Width = 93;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.oSDataGridViewTextBoxColumn.Width = 43;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.platformDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.platformDataGridViewTextBoxColumn.Width = 82;
            // 
            // hDDsizeDataGridViewTextBoxColumn
            // 
            this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
            this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDsizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hDDsizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDDsizeDataGridViewTextBoxColumn.Width = 99;
            // 
            // hDDspeedDataGridViewTextBoxColumn
            // 
            this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
            this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDspeedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hDDspeedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDDspeedDataGridViewTextBoxColumn.Width = 119;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gPUTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gPUTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gPUTypeDataGridViewTextBoxColumn.Width = 108;
            // 
            // opticaldriveDataGridViewTextBoxColumn
            // 
            this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
            this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
            this.opticaldriveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.opticaldriveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.opticaldriveDataGridViewTextBoxColumn.Width = 121;
            // 
            // audiotypeDataGridViewTextBoxColumn
            // 
            this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
            this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.audiotypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.audiotypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.audiotypeDataGridViewTextBoxColumn.Width = 111;
            // 
            // lANDataGridViewTextBoxColumn
            // 
            this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
            this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
            this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
            this.lANDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lANDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lANDataGridViewTextBoxColumn.Width = 53;
            // 
            // wIFIDataGridViewTextBoxColumn
            // 
            this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
            this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIFIDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wIFIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wIFIDataGridViewTextBoxColumn.Width = 54;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.widthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.widthDataGridViewTextBoxColumn.Width = 60;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.heightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.heightDataGridViewTextBoxColumn.Width = 68;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.depthDataGridViewTextBoxColumn.Width = 64;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.weightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.weightDataGridViewTextBoxColumn.Width = 71;
            // 
            // mousttypeDataGridViewTextBoxColumn
            // 
            this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.HeaderText = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
            this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mousttypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mousttypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mousttypeDataGridViewTextBoxColumn.Width = 112;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "power";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.powerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.powerDataGridViewTextBoxColumn.Width = 69;
            // 
            // webcamDataGridViewTextBoxColumn
            // 
            this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
            this.webcamDataGridViewTextBoxColumn.HeaderText = "webcam";
            this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
            this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
            this.webcamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.webcamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.webcamDataGridViewTextBoxColumn.Width = 88;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Comp123_Assign5.Model.Product);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dollarComputersDataSet1;
            // 
            // dollarComputersDataSet1
            // 
            this.dollarComputersDataSet1.DataSetName = "DollarComputersDataSet1";
            this.dollarComputersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dollarComputersDataSetBindingSource
            // 
            this.dollarComputersDataSetBindingSource.DataSource = this.dollarComputersDataSet;
            this.dollarComputersDataSetBindingSource.Position = 0;
            // 
            // dollarComputersDataSet
            // 
            this.dollarComputersDataSet.DataSetName = "DollarComputersDataSet";
            this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choiceLabel
            // 
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(258, 409);
            this.choiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(284, 29);
            this.choiceLabel.TabIndex = 3;
            this.choiceLabel.Text = "Your Choice:";
            this.choiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(8, 491);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(229, 59);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(544, 491);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(229, 59);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // selectionLabel
            // 
            this.selectionLabel.BackColor = System.Drawing.Color.White;
            this.selectionLabel.Location = new System.Drawing.Point(9, 438);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(764, 40);
            this.selectionLabel.TabIndex = 5;
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.dollarComputersDataGridView);
            this.Controls.Add(this.hardwareSelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hardwareSelectionLabel;
        private System.Windows.Forms.DataGridView dollarComputersDataGridView;
        private System.Windows.Forms.BindingSource dollarComputersDataSetBindingSource;
        private DollarComputersDataSet dollarComputersDataSet;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextButton;
        private DollarComputersDataSet1 dollarComputersDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DollarComputersDataSet1TableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
    }
}