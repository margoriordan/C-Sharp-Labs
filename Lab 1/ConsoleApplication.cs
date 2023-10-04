public class floringCostEstimator
{static void Main(string[] args)
    {
        //display title
        Console.WriteLine("Margo's Flooring Cost Estimator\n");

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

        //recieve user input
        Console.Write("Please enter the length of the floor: ");
        string inputLength = Console.ReadLine();
       
        Console.Write("Please enter the width of the floor: ");
        string inputWidth = Console.ReadLine();
        
        Console.Write("Please enter the cost per square foot for the flooring selected: ");
        string inputCostSqFt = Console.ReadLine();

        //convert input to usable data types
        floorLength = Convert.ToInt32(inputLength);
        floorWidth = Convert.ToInt32(inputWidth);
        costSqFt = Convert.ToDouble(inputCostSqFt);

        //visual separator
        Console.WriteLine("--------------------");

        //calculate labor hours, subtotals, and grand total
        floorArea = floorLength * floorWidth;
        costTotalArea = floorArea * costSqFt;
        installHours = (double) floorArea / laborRate;
        installCost = installHours * laborPricePerHour;
        totalCost = installCost + costTotalArea;
        
        //round results
        installHours = roundResult(installHours);
        installCost = roundResult(installCost);
        totalCost = roundResult(totalCost);
        
        //display results
        Console.WriteLine($"For a total floor size of {floorArea} the flooring cost is ${costTotalArea:n}.");
        Console.WriteLine($"It will take {installHours} hours to install the floor at a cost of ${installCost:n}.");
        Console.WriteLine($"\nThe total finished cost for the new floor is: ${totalCost:n}.");

    }
    
    //rounding function
    public static double roundResult(double result) => (Math.Round(result*100,MidpointRounding.AwayFromZero)/100);
}



