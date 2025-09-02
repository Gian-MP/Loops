using System;

public class loop
{
    public static void Main(string[] args)
    {
        
        for (int n = 1; n <50; n++){
            if(n%2==0){
                continue;
            }
            Console.WriteLine(n);
        }
    }
}
