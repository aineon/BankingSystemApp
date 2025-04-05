using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BankingSystemApp.TestMode;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace BankingSystemApp
{
    public partial class FrmLogin : Form
    {
        // Boolean property to store the TestMode setting
        // To change this go to Properties > Settings.settings > TestMode
        private readonly bool testMode = Properties.Settings.Default.TestMode;

        // A reference to the the text box that is currently in focus 
        private TextBox focusedTxtBox;

        // property to hold the Root Directory value
        public string RootDir { get; set; }
        
        static string fileName = "Login_Log.txt";

        static string filePath;

        public FrmLogin()
        {
            InitializeComponent();
            // Set the txtbAccNo to be the first textbox to have focus
            focusedTxtBox = txtbAccNo;
            // Give the textbox focus using .Focus() method
            focusedTxtBox.Focus();
        }

        // load the form, if in testMode load test login details
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            getRootDir();

            filePath = RootDir + fileName;

            if (testMode)
            {
                string cName = "";
                int accNo = 0;
                decimal bal = 0m;
                string pin = "";

                string sql = ($"Select * from Accounts Where CustomerName = '[Test Account]'");

                var testAccInfo = Data.GetData<Account>(sql, CommandType.Text);
                var account = testAccInfo[0];
                
                if (account.AccountNo > 0)
                {
                    cName = account.CustomerName;
                    accNo = account.AccountNo;
                    bal = account.Balance;
                    pin = account.PIN;
                }

                Account test = new Account(cName, accNo, bal, pin);

                txtbAccNo.Text = accNo.ToString();
                txtbPin.Text = pin.ToString();
            }
        }

        // Enter the number clicked into the currently focused textbox
        private void numBtn_Click(object sender, EventArgs e)
        {
            // Append the currently focused textbox with the value stroed in the .Text property of the button raising the event
            focusedTxtBox.Text += ((Button)sender).Text; // Cast sender to an object  
        }

        // focus textboxes
        private void txtbPin_Enter(object sender, EventArgs e)
        {
            focusedTxtBox = txtbPin;
        }

        private void txtbAccNo_Enter(object sender, EventArgs e)
        {
            focusedTxtBox = txtbAccNo;
        }

        // Ensure only numbers are entered into the textboxes but allow backspace
        private void ValidateTxtboxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("You may only enter numeric values!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        // Set max length of textboxes
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            if (txtbox.TextLength >= txtbox.MaxLength)
            {
                txtbox.Text = txtbox.Text.ToString().Substring(0, txtbox.MaxLength);
            }
        }

        // Authenticate the details input by the user against the details in the DB
        private Account authenticateUser()
        {
            // get the users input
            string accNoInput = txtbAccNo.Text;
            string pinInput = txtbPin.Text;

            string cName = "";
            int accNo = 0;
            decimal bal = 0m;
            string pin = "";

            string sql = ($"Select * from Accounts Where AccountNo = '{accNoInput}' and PIN = '{pinInput}'");

            var accountInfo = Data.GetData<Account>(sql, CommandType.Text);

            if(accountInfo.Count > 0)
            {
                var account = accountInfo[0];

                Account a = new Account(cName, accNo, bal, pin);

                if (account.AccountNo > 0)
                {
                    cName = account.CustomerName;
                    accNo = account.AccountNo;
                    bal = account.Balance;
                    pin = account.PIN;

                    if (pin == txtbPin.Text)
                    {
                        return account;
                    }               
                }             
            }          
            return null;
        }
        
        // Input from all textboxes and place focus on account number text box 
        private void ClearTxtBoxes()
        {
            txtbAccNo.Clear();
            txtbPin.Clear();
            txtbAccNo.Focus();
        }

        // If user is authenticated log them in and display bank account form else clear all textboxes so user can try again
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account userAcc = authenticateUser();
            bool loginSuccessful;

            if (userAcc != null)
            {
                if(testMode) 
                {
                    TestMode tMode = new TestMode();
                    tMode.ev_TestMode += HandleTestModeEvent;
                    tMode.CheckTestMode(testMode);
                }
                else
                {
                    loginSuccessful = true;
                    writeToLoginFile(loginSuccessful);
                }
                
                FrmBankAccount mainAccFrm = new FrmBankAccount(userAcc);
                mainAccFrm.Show();
                this.Hide();
            }
            else
            {
                loginSuccessful = false;
                writeToLoginFile(loginSuccessful);
                MessageBox.Show("The Account Number and/or the Pin Number entered is Incorrect.", "Incorrect Account Number/Pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTxtBoxes();
            }
        }
        // Event subscriber
        void HandleTestModeEvent(object sender, TestModeEventArgs e)
        {
            getRootDir();
            string testFileName = "TestMode_Login_Log.txt";
            string tFilePath;

            tFilePath = RootDir + testFileName;
             
            string testModeLogDetails = $"\nDate & Time: {DateTime.Now} - Account Number: {txtbAccNo.Text} | Successful: true |";
            File.AppendAllText(tFilePath, testModeLogDetails);
        }

        // Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Creates a Dialogue result object - to take user action
            DialogResult exitDialog = new DialogResult();
            exitDialog = MessageBox.Show("Are you sure you want to exit?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }        
        }

        // Clear input from the textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTxtBoxes();
        }

        // Get root directory of the exe
        private void getRootDir()
        {
            // get the location of the applications executable
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // we can now change to another folder once we have the executable 's directory location
            var d = System.IO.Path.GetDirectoryName(path);

            // Chop off the bin\Debug part of the directory string
            var dir = d.Replace("bin\\Debug", "");

            // Assign the directory value to the RootDir property
            RootDir = dir;
        }

        // Record all login attempts in a txt file
        private void writeToLoginFile(bool successful)
        {
            string logDetails = $"\nDate & Time: {DateTime.Now} - Account Number: {txtbAccNo.Text} | Successful: {successful} |";
            File.AppendAllText(filePath, logDetails);
        }

        // Event handlers to change back colour of buttons on mouse enter and change back on mouse out
        private void btnExitColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnExitColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(93,39,66);
        }

        private void btnLoginColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnLoginColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn1ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn1.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn1ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn2ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn2ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn3ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn3ColourChangBack_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn4ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn4.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn4ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn5ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn5.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn5ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn5.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn6ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn6.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn6ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn6.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn7ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn7.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn7ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn7.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn8ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn8.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn8ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn8.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn9ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn9.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn9ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn9.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btn0ColourChange_MouseEnter(object sender, EventArgs e)
        {
            btn0.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btn0ColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btn0.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btnClearColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnClearColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(93, 39, 66);
        }
    }
}
