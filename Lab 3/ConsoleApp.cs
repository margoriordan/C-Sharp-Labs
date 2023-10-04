public class HealthCalculator
{
    static void Main(string[] args)
    {
        //declare variables
        int heightInches;
        int weightLbs;
        int age;
        int restHeartRate;
        double BMI;

        //title & instructions
        Console.WriteLine("BMI and Karvonen Calculator\n");
        Console.WriteLine("Please enter the following values for the user . . .\n");
        
        //gather input
        Console.Write("Height in inches: ");
        string inputHeight = Console.ReadLine();

        Console.Write("Weight in pounds: ");
        string inputWeight = Console.ReadLine();

        Console.Write("Age: ");
        string inputAge = Console.ReadLine();

        Console.Write("Resting heart rate: ");
        string inputHeart = Console.ReadLine();

        //convert input to usable datatypes
        heightInches = Convert.ToInt32(inputHeight);
        weightLbs = Convert.ToInt32(inputWeight);
        age = Convert.ToInt32(inputAge);    
        restHeartRate = Convert.ToInt32(inputHeart);

        //calculate and display BMI
        Console.WriteLine();
        Console.WriteLine("Results . . .\n");

        double kilos = lbsToKg(weightLbs);
        double meters = inchesToMeters(heightInches);
        BMI = calculateBMI(kilos, meters);

        Console.WriteLine($"Your BMI is {BMI:0.00} -- {calculateBMICategory(BMI)}\n");

        //calculate and display intensity heart rates
        Console.WriteLine("Exercise Intensity Heart Rates:");
        Console.WriteLine("{0,0}{1,20}", "Intensity", "Max Heart Rate\n");

        calculateHeartRates(age, restHeartRate);
       

    }

   //functions
    public static double calculateBMI(double kilos, double meters)
    {
        return kilos/(Math.Pow(meters,2));
    }

    public static double lbsToKg(int pounds)
    {
        return pounds/2.2046;
    }

    public static double inchesToMeters(int inches)
    {
        return inches / 39.37;
    }

    public static string calculateBMICategory(double BMI)
    {
        string BMIcategory = "";
        if (BMI < 18.6)
        {
            BMIcategory = "Underweight";
        } 
        else if (BMI < 25)
        {
            BMIcategory = "Normal";
        } 
        else if (BMI < 30)
        {
            BMIcategory = "Overweight";
        } 
        else
        {
            BMIcategory = "Obese";
        }
        return BMIcategory;

    }

    public static void calculateHeartRates(int ageInYears, int heartRate)
    {
        int maxHeartRate = 220 - ageInYears;
        int heartRateReserve = maxHeartRate - heartRate;
        double percentage = .5;

        //calculate and display heart rates from 50% to 95% using Karvonen Formula
        for (double i = 0; i < 10; i++)
        {
            
            double maxTargetZone = heartRateReserve * percentage;
            double targetTrainingZone = heartRate + maxTargetZone;

            Console.WriteLine("{0,0}{1,10}{2,10}", $"{percentage:p0}","- -", $"{targetTrainingZone:n0}");

            percentage += .05;
         

        }
    }
    
    

}


