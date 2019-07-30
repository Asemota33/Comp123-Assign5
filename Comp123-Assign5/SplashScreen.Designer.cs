namespace Comp123_Assign5
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashPicture = new System.Windows.Forms.PictureBox();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.dollarComputersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splashPicture
            // 
            this.splashPicture.BackColor = System.Drawing.Color.Transparent;
            this.splashPicture.Image = ((System.Drawing.Image)(resources.GetObject("splashPicture.Image")));
            this.splashPicture.Location = new System.Drawing.Point(238, 150);
            this.splashPicture.Name = "splashPicture";
            this.splashPicture.Size = new System.Drawing.Size(323, 300);
            this.splashPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.splashPicture.TabIndex = 0;
            this.splashPicture.TabStop = false;
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 3000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // dollarComputersLabel
            // 
            this.dollarComputersLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarComputersLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dollarComputersLabel.Location = new System.Drawing.Point(12, 474);
            this.dollarComputersLabel.Name = "dollarComputersLabel";
            this.dollarComputersLabel.Size = new System.Drawing.Size(776, 65);
            this.dollarComputersLabel.TabIndex = 1;
            this.dollarComputersLabel.Text = "Dollar Computers";
            this.dollarComputersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dollarComputersLabel);
            this.Controls.Add(this.splashPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPicture;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.Label dollarComputersLabel;
    }
}