using System.Xml;

namespace Lab_6
{
    public partial class BankAcctManager : Form
    {
        BankAccount bankAccount = new BankAccount("000302019", 1362.59m);

        public BankAcctManager()
        {
            InitializeComponent();
            acctBlncTxt.Text = bankAccount.AccountBalance.ToString("C");
            acctNumTxt.Text = bankAccount.AccountNumber;
            bankAccount.balances.Add(bankAccount.AccountBalance);

        }

        private void depositRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void withdrlRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal amount = Decimal.Parse(amtTxt.Text);

                    if (depositRadio.Checked)
                    {
                        bankAccount.Deposit(amount);

                    }
                    else if (withdrlRadio.Checked)
                    {
                        bankAccount.Withdrawal(amount);

                    }
                    acctBlncTxt.Text = bankAccount.AccountBalance.ToString("C");
                    amtTxt.Text = "";

                    bankAccount.GetAccountStatus(bankAccount.AccountBalance);
                    statusTxt.Text = bankAccount.statusMsg.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            

        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            historyTxt.Text = "";
            bankAccount.balances.Reverse();//list balance history in order starting with most recent
            foreach (decimal balance in bankAccount.balances)
            {
                historyTxt.Text += balance.ToString("C");
                historyTxt.Text += Environment.NewLine;
            }
            bankAccount.balances.Reverse();//reverse again to prepare list for additional balances in chron order

        }

        private void statusBtn_Click(object sender, EventArgs e)
        {

            statusTxt.Text = "";
            String currentStatus = "";
            if (bankAccount.AccountBalance > 0)
            {
                currentStatus = "Your account is currently okay.";

            }
            else if (bankAccount.AccountBalance < 0)
            {
                currentStatus = "Your account is overdrawn. Please make a deposit.";
            }
            else
            {
                currentStatus = "Your account is empty.";
            }
            MessageBox.Show($"{currentStatus}", "Account Status");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amtTxt_TextChanged(object sender, EventArgs e)
        {
            //clear all possible options & messages before another transaction occurs
            depositRadio.Checked = false;
            withdrlRadio.Checked = false;
            statusTxt.Text = "";
        }

        public bool IsValidData()
        {
            bool success = true;
            string errorMsg = "";

            //validate transaction amount
            errorMsg += IsPresent(amtTxt.Text, "Transaction Amount");
            errorMsg += IsDecimal(amtTxt.Text, "Transaction Amount");


            if (errorMsg != "")
            {
                success = false;
                MessageBox.Show(errorMsg, "Entry Error");
            }
            return success;
        }

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " cannot be left empty.\n";
            }
            return msg;
        }
        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }
            return msg;
        }
    }
}