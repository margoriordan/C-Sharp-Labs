using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class BankAccount
    {
        public BankAccount(String accountNum, decimal accountBlnc) { 
                this.AccountBalance = accountBlnc;
                this.AccountNumber = accountNum;
        }

        public String AccountNumber { get; }

        private decimal accountBalance;
        public decimal AccountBalance
        {
            get { return GetAccountBalance(); }
            private set { accountBalance = value; }
        }

        Status transStatus;
        public List<decimal> balances { get; private set; } = new List<decimal>();

        public void Withdrawal(decimal amount)
        {
            decimal transAmt = accountBalance - amount;
            
            if (accountBalance < -100 || transAmt < -100) {

                transStatus = Status.InsufficientFunds;
                
            } 
            else if (amount > accountBalance && transAmt > -100m) 
            {
                transStatus = Status.InsufficientFunds;
                accountBalance = transAmt - 35.75m;
                transStatus = Status.Overdrawn;
                balances.Add(transAmt);
                balances.Add(accountBalance);
            } else 
            {
                accountBalance = transAmt;
                transStatus = Status.Ok;
                balances.Add(accountBalance);
            }

        }

        public void Deposit(decimal amount)
        {
            if (amount >= 10000)
            {
                transStatus = Status.DepositTooLarge;
       
            }
            else if (amount < 10000)
            {   
                accountBalance += amount;
                transStatus = Status.Ok;
                balances.Add(accountBalance);
            }
        }

        public enum Status
        {
            Ok,
            Overdrawn,
            InsufficientFunds,
            DepositTooLarge
        }

        public String statusMsg = "";
        public string GetAccountStatus(decimal accountBlc) {
            
            switch (transStatus)
            {
                case Status.Ok:
                    statusMsg = "Transaction successful!";
                    break;
                case Status.Overdrawn:
                    statusMsg = "Your account is overdrawn. Please make a deposit.";
                    break;
                case Status.InsufficientFunds:
                    statusMsg = "Your account has insufficient funds for this transaction.";
                    break;
                case Status.DepositTooLarge:
                    statusMsg = "Deposits must be less than 10,000. Please see teller.";
                    break;
            } return statusMsg;
        
        }
        private decimal GetAccountBalance()
        {
            return this.accountBalance ;
        }

    }
}
