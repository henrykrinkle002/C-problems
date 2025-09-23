using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


//the sum of the numbers and count the number of pairs.
class Result
{

    /*
     * Complete the 'countAffordablePairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER budget
     */

    public static int countAffordablePairs(List<int> prices, int budget)
    {   int left=0, right= prices.Count - 1, count=0;
        while(left<=right){
            if(prices[left] + prices[right] <= budget){
                count += (right - left);
                left++;
            }else{
                right--;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int pricesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> prices = new List<int>();

        for (int i = 0; i < pricesCount; i++)
        {
            int pricesItem = Convert.ToInt32(Console.ReadLine().Trim());
            prices.Add(pricesItem);
        }

        int budget = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countAffordablePairs(prices, budget);

        Console.WriteLine(result);
    }
}
