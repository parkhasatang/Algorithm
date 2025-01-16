using System;
using System.Collections.Generic;

public class Solution 
{
    // 최대공약수를 구하는 메서드
    private int GetGCD(int a, int b) 
    {
        // 유클리드 알고리즘 사용
        while (b != 0) 
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public int[] solution(int n, int m) 
    {
        // 최대공약수 계산
        int gcd = GetGCD(n, m);
        // 최소공배수 계산
        int lcm = (n * m) / gcd;

        List<int> answerList = new List<int>();
        answerList.Add(gcd);
        answerList.Add(lcm);

        return answerList.ToArray();
    }
}
