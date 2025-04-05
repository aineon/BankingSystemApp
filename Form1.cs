using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        // Declare list of Accounts
        private static List<Account> accounts = new List<Account>();

        // property to hold the Root Directory value
        public string RootDir { get; set; }
        // 
        static string fileName = "Login_Log.txt";

        static string filePath;

        public int attemptsCount = 0;

        public FrmLogin()
        {
            InitializeComponent();
            // Set the txtbAccNo to be the first textbox to have focus
            focusedTxtBox = txtbAccNo;
            // Give the textbox focus using .Focus() method
            focusedTxtBox.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            getRootDir();

            filePath = RootDir + fileName;

            //// Create objects of Account type, passing in a name, initial balance and pin number
            //Account acc1 = new Account("Dean Winchester", "6669", 10000);
            //Account acc2 = new Account("Billy Butcher", "1234", 150);
            //Account acc3 = new Account("Natasha Romanov", "2468", 150000);
            //Account acc4 = new Account("Mildred Ratched", "1357", 1320);
            //Account acc5 = new Account("Hans Gruber", "0340", 10000000);
            //Account acc6 = new Account("Danny Torrence", "0217", 217);


            //// Add account objects to the list
            //accounts.Add(acc1);
            //accounts.Add(acc2);
            //accounts.Add(acc3);
            //accounts.Add(acc4);
            //accounts.Add(acc5);
            //accounts.Add(acc6);

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


        private void numBtn_Click(object sender, EventArgs e)
        {
            // Append the currently focused textbox with the value stroed in the .Text property of the button raising the event
            focusedTxtBox.Text += ((Button)sender).Text; // Cast sender to an object    
        }

        private void txtbPin_Enter(object sender, EventArgs e)
        {
            focusedTxtBox = txtbPin;
        }

        private void txtbAccNo_Enter(object sender, EventArgs e)
        {
            focusedTxtBox = txtbAccNo;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            if (txtbox.TextLength >= txtbox.MaxLength)
            {
                txtbox.Text = txtbox.Text.ToString().Substring(0, txtbox.MaxLength);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Maybe add code to count attempts and give them 3 attempts to login otherwise they are locked out????

            Account userAcc = authenticateUser();
            bool loginSuccessful;

            if (userAcc != null)
            {
                loginSuccessful = true;
                writeToLoginFile(loginSuccessful);
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
        private void ClearTxtBoxes()
        {
            txtbAccNo.Clear();
            txtbPin.Clear();
            txtbAccNo.Focus();
        }

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
            
          
            var account = accountInfo[0];
            if (account.AccountNo > 0)
            {
                cName = account.CustomerName;
                accNo = account.AccountNo;
                bal = account.Balance;
                pin = account.PIN;
            }

            Account a = new Account(cName, accNo, bal, pin);

            if(pin == txtbPin.Text)
            {
                return account;
            }
            else
            {
                return null;
            }
 
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTxtBoxes();
        }

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

        private void writeToLoginFile(bool successful)
        {
            string logDetails = $"\nDate&Time: {DateTime.Now} - AccountNumber: {txtbAccNo.Text} | Successful: {successful} |";
            File.AppendAllText(filePath, logDetails);
        }
    }
}
