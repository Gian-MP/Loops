using System;

public class Loop
{
    public static void Main(string[] args)
    {
        int result = 1; 
        Console.WriteLine("Enter the base number:"); 
        int Base = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter the exponent:"); 
        int exponent = Convert.ToInt32(Console.ReadLine());
        
        for (int n = 0; n < exponent; n++) {
            result = result * Base; 
            
        }
        Console.WriteLine(result);
    }
}
