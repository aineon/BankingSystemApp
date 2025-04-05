using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankingSystemApp.TestMode;

namespace BankingSystemApp
{
    public partial class FrmBankAccount : Form
    {
        // Set the culture to english-Ireland and show currencies in Euro
        private static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-IE");

        private Account UserAcc;

        public decimal Amt;

        public string RootDir { get; set; }

        static string fileName = "Transaction_Log.txt";

        static string filePath;

        public FrmBankAccount(Account userAcc)
        {
            InitializeComponent();
            UserAcc = userAcc;
        }
       
        private void FrmBankAccount_Load(object sender, EventArgs e)
        {
            LoadAccountDetails();
            getRootDir();
            filePath = RootDir + fileName;
            rbDeposit.Checked = true;
            txtbAmount.Focus();
        }

        // Populate the form with Customer name, account no & balance 
        private void LoadAccountDetails()
        {
            lblAccName.Text = UserAcc.CustomerName.Substring(1, UserAcc.CustomerName.Length -2);
            lblAccNo.Text = UserAcc.AccountNo.ToString();
            lblBalance.Text = string.Format(culture, "{0:C2}", UserAcc.Balance);
        }

        // Enter the number clicked into the textbox
        private void mainNumBtn_Click(object sender, EventArgs e)
        {
            txtbAmount.Text += ((Button)sender).Text;
        }

        // Clear input from the textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbAmount.Clear();
        }

        // Ensure that only numbers or a '.' are entered into the textbox but backspace is allowed
        private void ValidateAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != '.') && (!char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("The character you have entered in invalid!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Input must be a number or '.'! Deposit amount must be greater than 0!";
                e.Handled = true;
            }
        }

        // If a valid amount is entered, execute the transaction and update the balance
        private void ExecuteTransaction()
        {
            lblMessage.Text = "";

            bool amountVerified = false;
            decimal amt = 0.00m;
                      
            if (decimal.TryParse(txtbAmount.Text, out amt)) // assigns the txtbAmount to inputAmt if it can be parsed to a decimal
            {
                amountVerified = true;
            }

            if (amountVerified) 
            {       
                try 
                { 
                    if (rbDeposit.Checked)
                    {
                        if (txtbAmount.TextLength > 0)
                        { 
                            if(lblAccName.Text == "Test Account")
                            {
                                bool testMode = true;

                                UserAcc.DepositTrans(amt);
                                updateBalance();
                                lblMessage.ForeColor = Color.FromArgb(38, 201, 38);
                                lblMessage.Text = $"You have successfully deposited €{amt} to your account.";
                                lblBalance.Text = string.Format(culture, "{0:C2}", UserAcc.Balance);

                                TestMode tMode = new TestMode();
                                tMode.ev_TestMode += HandleTestModeEvent;
                                tMode.CheckTestMode(testMode);
                            }    
                            else
                            {
                                UserAcc.DepositTrans(amt);
                                updateBalance();
                                lblMessage.ForeColor = Color.FromArgb(38, 201, 38);
                                lblMessage.Text = $"You have successfully deposited €{amt} to your account.";
                                lblBalance.Text = string.Format(culture, "{0:C2}", UserAcc.Balance);
                                string amount = string.Format(culture, "{0:C2}", amt);
                                writeToTransactionLogFile("Deposit", amount);                               
                            }                                         
                        }                    
                    }
                    else 
                    {
                        if (txtbAmount.TextLength > 0)
                        {
                            if (lblAccName.Text == "Test Account")
                            {
                                bool testMode = true;

                                UserAcc.WithdrawTrans(amt);
                                updateBalance();
                                lblMessage.ForeColor = Color.FromArgb(38, 201, 38); 
                                lblMessage.Text = $"You have successfully withdrawn €{amt} from your account.";
                                lblBalance.Text = string.Format(culture, "{0:C2}", UserAcc.Balance);

                                TestMode tMode = new TestMode();
                                tMode.ev_TestMode += HandleTestModeEvent;
                                tMode.CheckTestMode(testMode);
                            }
                            else
                            {
                                UserAcc.WithdrawTrans(amt);
                                updateBalance();
                                lblMessage.ForeColor = Color.FromArgb(38, 201, 38);
                                lblMessage.Text = $"You have successfully withdrawn €{amt} from your account.";
                                lblBalance.Text = string.Format(culture, "{0:C2}", UserAcc.Balance);
                                string amount = string.Format(culture, "{0:C2}", amt);
                                writeToTransactionLogFile("Withdrawal", amount);        
                            }
                        } 
                    }
                }
                catch (ArgumentOutOfRangeException a)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = a.Message;
                }
                catch (InvalidOperationException i)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = i.Message;
                }
                catch (FormatException)
                {
                    lblMessage.Text = "Incorrect format, can only contain 1 decimal point!";
                }
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Incorrect format, amount must be greater than 0.";
                txtbAmount.Clear();
            }
            txtbAmount.Clear();
        }

        void HandleTestModeEvent(object sender, TestModeEventArgs e)
        {
            getRootDir();
            string testFileName = "TestMode_TransactionLog.txt";
            string tFilePath;

            tFilePath = RootDir + testFileName;

            string transactionType = "";
            decimal newBal = 0.0m;

            if (rbDeposit.Checked)
            {
                transactionType = "Deposit";
                newBal = Amt + UserAcc.Balance;
            }
            else 
            {
                transactionType = "Withdrawal";
                newBal = UserAcc.Balance - Amt;
            }

            string newBalance = string.Format(culture, "{0:C2}", newBal);
            string testModeTransactionDetails = $"\nDate & Time: {DateTime.Now} - Account Number: {lblAccNo.Text} | Customer Name: {UserAcc.CustomerName} | TransactionType: {transactionType} | Amount: €{txtbAmount.Text} | New Balance: {newBalance}";
   
            File.AppendAllText(tFilePath, testModeTransactionDetails);
        }

        // Update the balance in the DB
        private void updateBalance()
        {
            string sql = ($"Update Accounts Set Balance = {UserAcc.Balance} Where AccountNo = {UserAcc.AccountNo}");

            Data.ExecuteSqlNonQuery(sql, CommandType.Text);
        }

// Button Click Events

        // Clicking Confirm will execute the transaction
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ExecuteTransaction();
        }

        // Logs user out of their account and returns them to the login screen
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();      
        }

        // Show the login in form no matter how the user logs out - eg clicks logout btn or uses 'x' to close the form
        private void FrmBankAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmLogin().Show();
        }

        // Get the root directory of the exe
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

        // Record all successful transaction in a txt file
        private void writeToTransactionLogFile(string transactionType, string amt)
        {
            string balance = string.Format(culture, "{0:C2}", UserAcc.Balance);
            string transactionDetails = $"\nDate & Time: {DateTime.Now} - Account Number: {lblAccNo.Text} | Customer Name: {UserAcc.CustomerName} | TransactionType: {transactionType} | Amount: {amt} | New Balance: {balance}";
            File.AppendAllText(filePath, transactionDetails);
        }

 // Change back colour on buttons on mouse enter and mouse out
        private void btnLogoutColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnLogoutColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(93, 39, 66);
        }

        private void btnConfirmColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnConfirmColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(93, 39, 66);
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

        private void btnDotColourChange_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(165, 84, 124);
        }

        private void btnDotColourChangeBack_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(93, 39, 66);
        }      
    }
}
