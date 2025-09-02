using System;

public class Loop
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:"); 
        int number = Convert.ToInt32(Console.ReadLine());
        
        int total = 0;
        while (number > 0)  
    {
        int digit = number % 10;  
        if (digit % 2 !=0){
            total = total + digit;
        }
        number = number / 10;     
    }
            Console.WriteLine("The total of the odd numbers in your given number is:");
            Console.WriteLine(total);

            
        
    }
}
