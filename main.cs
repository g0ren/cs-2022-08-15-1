using System;
using System.Text.RegularExpressions;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int r = 0;
        foreach (var c in stones)
        {
            if (jewels.Contains(c))
            {
                ++r;
            }
        }
        return r;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = Regex.Replace(input, @"\s+", "");
        string[] split = input.Split(',');
        string jewels = split[0].Split('=')[1];
        string stones = split[1].Split('=')[1];
        jewels = Regex.Replace(jewels, @"""", "");
        stones = Regex.Replace(stones, "\"", "");
        Solution s = new Solution();
        Console.WriteLine("{0}", s.NumJewelsInStones(jewels, stones));
    }
}