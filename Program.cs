using System;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}