using System.Security.Cryptography.X509Certificates;

namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
           try
            {
                if (IsValidData())
                {
                    decimal interestRate = Convert.ToDecimal(interest_rate.Text);
                    decimal purchasePrice = Convert.ToDecimal(purchase_price.Text);
                    decimal downPayment = Convert.ToDecimal(down_pymnt.Text);
                    decimal totalAmtFin = purchasePrice - downPayment;
                    decimal totalMonths = Convert.ToDecimal(loan_term.Text);

                    decimal monthlyInterestRate = interestRate / 100 / 12;
                    decimal totalMonthlyCost = CalculateMonthly(monthlyInterestRate, totalAmtFin, totalMonths);

                    amnt_finance_txt.Text = $"{totalAmtFin:c}";
                    monthly_pymt_txt.Text = $"{totalMonthlyCost:c}";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }

        }

        public bool IsValidData()
        {
            bool success = true;
            string errorMsg = "";

            //validate purchase price
            errorMsg += IsPresent(purchase_price.Text, "Purchase Price");
            errorMsg += IsDecimal(purchase_price.Text, "Purchase Price");

            //validate down payment amount
            errorMsg += IsPresent(down_pymnt.Text, "Down Payment Amount");
            errorMsg += IsDecimal(down_pymnt.Text, "Down Payment Amount");

            //validate interest rate
            errorMsg += IsPresent(interest_rate.Text, "Interest Rate");
            errorMsg += IsDecimal(interest_rate.Text, "Interest Rate");


            //validate loan term
            errorMsg += IsPresent(loan_term.Text, "Loan Term in Months");
            errorMsg += IsInt(loan_term.Text, "Loan Term in Months");

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

        public static string IsInt(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
            }
            return msg;
        }


        public static decimal CalculateMonthly(decimal interestRate, decimal totalAmtFin, decimal totalMonths)
        {

            double totalMonthlyDbl;
            double interestRateDbl = Convert.ToDouble(interestRate);
            double totalAmtFinDbl = Convert.ToDouble(totalAmtFin);
            double totalMonthsDbl = Convert.ToDouble(totalMonths);
            double onePlusIntrst = (1 + interestRateDbl);

            totalMonthlyDbl = interestRateDbl * totalAmtFinDbl * (Math.Pow(onePlusIntrst, totalMonthsDbl) / (Math.Pow(onePlusIntrst, totalMonthsDbl) - 1));

            decimal totalMonthly = Convert.ToDecimal(totalMonthlyDbl);
            return totalMonthly;

        }

        private void ClearPrevious(object sender, EventArgs e)
        {
            amnt_finance_txt.Clear();
            monthly_pymt_txt.Clear();
        }
    }
    //Function 'IsNotNegative cannot handle empty string'
    /*public static string IsNotNegative(string value, string name)
    {
        if (IsPresent())
        {
            string msg = "";
            decimal convertDec = Convert.ToDecimal(value);
            if (convertDec < 0)
            {
                msg = name + " cannot be negative.\n";
            }
            return msg;
        }
    }*/
}