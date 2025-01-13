using System;
using System.Windows.Forms;

namespace items
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the Form1 (your main form)
            Application.Run(new Form1());
        }
    }
}
