using System;

public class calculateGrade
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter grade point: ");
        string txtGradePoint = Console.ReadLine();

        string letterGrade = "";
        int gradePoint = Convert.ToInt32(txtGradePoint);

        if (gradePoint < 60 )
        {
            letterGrade = "F";
        } 
        else if (gradePoint < 68)
        {
            letterGrade = "D";
        } 
        else if (gradePoint < 80)
        {
            letterGrade = "C";
        }
        else if (gradePoint < 88)
        {
            letterGrade = "B";
        } 
        else { letterGrade = "A";
        }

        Console.Clear();

        Console.WriteLine("{0, 0}{0, 16}", " ============");
        Console.WriteLine("{0, 0}{1, 18}","|Grade Point", "Letter Grade|");
        Console.WriteLine("{0, 0}{0, 16}", " ============");
        Console.WriteLine("{0, 0}{1, 15}{2, 12}", $"|{gradePoint}",$"{letterGrade}", "|");
        Console.WriteLine(" ============================");
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();  
        
    }
}
