using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace CreditInquiry
{
    public partial class CreditInquiryForm : Form
    {
        private FileStream input;  // Maintains connection to the file
        private StreamReader fileReader;  // Reads data from text file

        public CreditInquiryForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // Create dialog box enabling user to open file
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // Exit event handler if user clicked cancel
            if (result == DialogResult.OK)
            {
                // Show error if user specified invalid file type
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid file name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Create FileStream to obtain read access to file
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    // Set file from where data is read
                    fileReader = new StreamReader(input);

                    // Enable all GUI buttons except for Open File button
                    openButton.Enabled = false;
                    getBalancesButton.Enabled = true;
                    debitButton.Enabled = true;
                    zeroButton.Enabled = true;
                }
            }
        }

        private void getBalancesButton_Click(object sender, EventArgs e)
        {
            // Convert sender explicitly to object of type button
            Button senderButton = (Button)sender;

            string accountType = senderButton.Text;

            // Read and display file information
            try
            {
                input.Seek(0, SeekOrigin.Begin);

                displayTextBox.Text = $"Accounts with {accountType}{Environment.NewLine}";

                // Travers file until end of file
                while (true)
                {
                    // get next Record available in the file
                    string inputRecord = fileReader.ReadLine();

                    // When at the end of file, exit method
                    if (inputRecord == null)
                    {
                        return;
                    }

                    // Parse input
                    string[] inputFields = inputRecord.Split(',');

                    // Create Record from input
                    var record = new Record(int.Parse(inputFields[0]), inputFields[1], inputFields[2], decimal.Parse(inputFields[3]));

                    // Determine whether to display balance
                    if (ShouldDisplay(record.Balance, accountType))
                    {
                        // Display Record
                        displayTextBox.AppendText($"{record.Account}\t" +
                            $"{record.FirstName}\t{record.LastName}\t" +
                            $"{record.Balance:C}{Environment.NewLine }");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot read file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Determine whether to display given record
        private bool ShouldDisplay(decimal balance, string accountType)
        {
            if (balance > 0M && accountType == "Credit Balances")
            {
                return true;
            }
            else if (balance < 0M && accountType == "Debit Balances")
            {
                return true;
            } 
            else if (balance == 0 && accountType == "Zero Balances")
            {
                return true;
            }

            return false;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            // Close file and StreamReader
            try
            {
                fileReader?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
