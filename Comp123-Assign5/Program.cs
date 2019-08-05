using Comp123_Assign5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_Assign5
{
     public static class Program
    {
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static ProductClass productClass;
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

            productClass = new ProductClass();
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
