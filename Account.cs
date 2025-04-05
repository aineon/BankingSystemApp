using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystemApp
{
    public class Account
    {
        /// <summary>
        /// This class represents an Account
        /// </summary>
       
        // Properties to store Account details
        public string CustomerName { get; set; }

        public int AccountNo { get; set; }

        public decimal Balance { get; set; }

       public string PIN { get; set; }

        // Method to allow user to deposit money into their account.
        // Validates user input to ensure they have entered a valid ammount
        public void DepositTrans(decimal amount)
        {
            if (amount <= 0)
            {
                // nameof() gets the name of the parameter
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount to be desposited must be greater than 0");
            }
            else
            {
               Balance += amount;
            }
        }

        // Method to allow user to withdraw money from their account.
        // Validates user input to ensure they have entered a valid ammount and that they have sufficient funds to make the withdrawal
        public void WithdrawTrans(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount to be withdrawn must be greater than 0");
            }
            else if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient Funds! Cannot complete transaction! Please enter a lower amount");
            }
            else
            {
               Balance -= amount;
            }
        }
        public Account()
        {
        }
        // Overload Constructor
        // This sets the users account info (name, initial balance, pin & acc number)
        public Account(string name, int accNo,  decimal initialBal, string pin)
        {
            // Assign passed in variable values to the property values
            CustomerName = name;
            PIN = pin;
            Balance = initialBal;
            AccountNo = accNo;
        }
    }
}
