namespace Exercise_1_WinForm
{
    public partial class MargoFloorCostEstimator : Form
    {
        public MargoFloorCostEstimator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputFloorLength_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnCalc_Click(object sender, EventArgs e)
        {

            //declare variables
            int floorLength = 0;
            int floorWidth = 0;
            int floorArea = 0;
            double costSqFt = 0;
            double costTotalArea = 0;
            double installHours = 0;
            double installCost = 0;
            double totalCost = 0;

            //declare constants
            const double laborPricePerHour = 35.75;
            const double laborRate = 40.00;

            //read and store user input for calulations 
            int.TryParse(inputFloorLength.Text, out floorLength);
            int.TryParse(inputFloorWidth.Text, out floorWidth);
            double.TryParse(inputCostSqFt.Text, out costSqFt);

            //calculate labor hours, subtotals, and grand total
            floorArea = floorLength * floorWidth;
            costTotalArea = floorArea * costSqFt;
            installHours = (double)floorArea / laborRate;
            installCost = installHours * laborPricePerHour;
            totalCost = installCost + costTotalArea;

            //round results
            installHours = roundResult(installHours);
            installCost = roundResult(installCost);
            totalCost = roundResult(totalCost);

            //display results
            txtFloorArea.Text = $"{floorArea}";
            txtAreaCost.Text = $"${costTotalArea:n}";
            txtNumHours.Text = $"{installHours:n}";
            txtInstallCost.Text = $"${installCost:n}";
            txtGrandTotal.Text = $"${totalCost:n}";
        }
        //rounding function
        public static double roundResult(double result) => (Math.Round(result * 100, MidpointRounding.AwayFromZero) / 100);
    }


}