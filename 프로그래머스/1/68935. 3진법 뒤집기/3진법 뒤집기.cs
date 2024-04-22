using System;
using static System.Math;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) 
    {
        List<int> list = new List<int>();
        int answer = 0;
        while(n > 0)
        {
            int j = n%3;
            list.Add(j);
            n = n/3;
        }
        list.Reverse();
        
        for (int i = 0; i < list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3,i));
        }
        
        return answer;
    }
}