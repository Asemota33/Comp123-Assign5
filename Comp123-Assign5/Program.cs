using Comp123_Assign5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Michael Asemota
 * App Name: Dollar Computers
 * App Creation Date: 8/16/2019
 * Student #: 301052117
 * Description: This file is where the all the forms are instantiated  
 */

namespace Comp123_Assign5
{
     public static class Program
    {
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            orderForm = new OrderForm();
            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashScreen);
        }
    }
}
