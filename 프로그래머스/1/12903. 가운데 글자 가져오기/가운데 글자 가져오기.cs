using System;

public class Solution 
{
    public string solution(string s) 
    {
        int length = s.Length;
        
        if (length % 2 == 0)
        {
            int middle = length / 2 - 1;
            return s.Substring(middle, 2);            
        }
        else 
        {
            int middle = length / 2;
            return s[middle].ToString();
        }
    }
}