using System;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logger.Info("MainForm loaded.");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("MainForm closed.");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBoxNumber.Text);
                logger.Info($"You entered the number: {number}");

                DateTime date = DateTime.Parse(textBoxDate.Text);
                logger.Info($"You entered the date: {date.ToShortDateString()}");

                char symbol = char.Parse(textBoxSymbol.Text);
                logger.Info($"You entered the symbol: '{symbol}'");
            }
            catch (FormatException ex)
            {
                logger.Error(ex, "Type conversion error occurred.");
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
