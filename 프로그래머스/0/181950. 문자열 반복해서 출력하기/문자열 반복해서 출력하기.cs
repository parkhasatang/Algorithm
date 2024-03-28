using System;

public class Example
{
    public static void Main()
    {
        string[] input;
        string answer = "";

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        string s1 = input[0];
        int a = Int32.Parse(input[1]);

        for (int i = 0; i < a; i++)
        {
            answer += s1;
        }
        
        Console.WriteLine(answer);
    }
}