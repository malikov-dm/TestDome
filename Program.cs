using System;
using System.Collections.Generic;
/* 
    TestDome Two Sum

    https://www.testdome.com/questions/c-sharp/two-sum/

    Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, 
    two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. 
    If there are no two numbers, the function should return null.
    For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:
    > 0 and 3 (or 3 and 0) as 3 + 7 = 10
    > 1 and 5 (or 5 and 1) as 1 + 9 = 10
    > 2 and 4 (or 4 and 2) as 5 + 5 = 10 
*/

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        if (list.Count < 2)
        {
            return null;
        }

        var dic = new Dictionary<int, int>();
        for (var i = 0; i < list.Count; i++)
        {
            var value = list[i];
            if (!dic.ContainsKey(value))
            {
                dic.Add(value, i);
            }
        }

        for (var j = 0; j < list.Count; j++)
        {
            var diff = sum - list[j];
            if (dic.ContainsKey(diff))
            {
                var diffInd = dic[diff];
                if(diffInd != j)
                    return new Tuple<int, int>(j, diffInd);
            }
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 5, 1, 2, 7, 8, 5 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}