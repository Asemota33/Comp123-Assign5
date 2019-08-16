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
 * Description: This form displays a splash screen for 3 seconds
 */
namespace Comp123_Assign5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This event disables the timer and opens up the start form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This event adds a timer to the splash screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Enabled = true;
        }
    }
}
