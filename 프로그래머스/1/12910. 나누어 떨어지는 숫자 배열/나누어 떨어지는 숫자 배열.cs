using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) 
    {
        List<int> resultList = new List<int>();

        foreach (int num in arr) 
        {
            if (num % divisor == 0) 
            {
                resultList.Add(num);
            }
        }

        if (resultList.Count == 0) 
        {
            return new int[] { -1 };
        }

        resultList.Sort();
        return resultList.ToArray();
    }
}