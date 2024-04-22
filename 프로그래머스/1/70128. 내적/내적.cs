using System;

public class Solution {
    public int solution(int[] a, int[] b) 
    {
        int n = a.Length;
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            answer += a[i-1]*b[i-1];
        }
        
        return answer;
    }
}