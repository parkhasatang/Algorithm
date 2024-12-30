using System;

public class Solution 
{
    public int solution(int[,] targets) 
    {
        int n = targets.GetLength(0);
        var intervals = new (int s, int e)[n];
        for(int i=0; i<n; i++)
        {
            intervals[i] = (targets[i, 0], targets[i, 1]);
        }

        Array.Sort(intervals, (a, b) =>
        {
            if (a.e == b.e) return a.s.CompareTo(b.s);
            return a.e.CompareTo(b.e);
        });

        int answer = 0;
        double lastShot = double.NegativeInfinity;

        foreach (var interval in intervals)
        {
            int start = interval.s;
            int end   = interval.e;
            
            if (!(start < lastShot && lastShot < end))
            {
                answer++;
                lastShot = end - 0.5;
            }
        }
        
        return answer;
    }
}
