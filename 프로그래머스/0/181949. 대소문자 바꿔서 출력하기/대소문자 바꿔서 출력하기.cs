using System;

public class Example
{
    public static void Main()
    {
        String s;
        string answer = "";

        Console.Clear();
        s = Console.ReadLine();

        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                answer += char.ToLower(c);
            }
            else 
            {
                answer += char.ToUpper(c);
            }
        }
        Console.WriteLine(answer);
    }
}