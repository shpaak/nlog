using System;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsApp
{
    static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                logger.Info("Application started.");

                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An unhandled exception occurred.");
                MessageBox.Show("An error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                logger.Info("Application closed.");
                LogManager.Shutdown();
            }
        }
    }
}