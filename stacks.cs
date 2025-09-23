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



class Result
{

    /*
     * Complete the 'processCouponStackOperations' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY operations as parameter.
     */

    public static List<int> processCouponStackOperations(List<string> operations)
    {
        int n = operations.Count;
        Stack<int> stack = new Stack<int>();
        List<int> result = new List<int>();
        
        foreach (var oper in operations){
            if(oper.StartsWith("push")){
                var parts = oper.Split(" ");
                int num = int.Parse(parts[1]);
                
                stack.Push(num);
            }
            else if(oper.StartsWith("pop")){
                stack.Pop();
            }
            else if(oper.StartsWith("getMin")){
                result.Add(stack.Min());
            }
            else if(oper.StartsWith("top")){
                result.Add(stack.Peek());
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int operationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> operations = new List<string>();

        for (int i = 0; i < operationsCount; i++)
        {
            string operationsItem = Console.ReadLine();
            operations.Add(operationsItem);
        }

        List<int> result = Result.processCouponStackOperations(operations);

        Console.WriteLine(String.Join("\n", result));
    }
}
