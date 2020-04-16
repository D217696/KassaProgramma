using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSysteem_v1._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        /*
         * Arrays to store article data.
         * The actual data is stored in the Form1.cs
         */
        public static string[] articleNumber = new string[100];
        public static string[] articleDescription = new string[100];
        public static float[]  articlePrice = new float[100];
        public static string[] articlePicture = new string[100];

        public static int[] receiptArticleNumber = new int[50];
        public static int[] receiptArticleAmount = new int[50];

                
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
