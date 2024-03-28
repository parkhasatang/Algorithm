using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        for (int i = 0; i < strings.Length - 1; i++)
        {
            for (int j = 0; j < strings.Length - i - 1; j++)
            {
                if (strings[j][n] > strings[j + 1][n] ||
                    (strings[j][n] == strings[j + 1][n] && string.Compare(strings[j], strings[j + 1]) > 0))
                {
                    SwapStrings(strings, j, j + 1);
                }
            }
        }

        return strings;
    }

    private void SwapStrings(string[] array, int index1, int index2)
    {
        string temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}