using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[1]);
        int b = Int32.Parse(s[0]);

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j ++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}