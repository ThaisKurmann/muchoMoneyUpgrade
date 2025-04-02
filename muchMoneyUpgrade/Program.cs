using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muchMoneyUpgrade
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string MuchMoneyPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MuchMoney";

            bool checkPath = Directory.Exists(MuchMoneyPath);
            if (!checkPath)
            {
                Directory.CreateDirectory(MuchMoneyPath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
           
        }
    }
}
