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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long maxElement = long.MinValue;
        long minElement = long.MaxValue;
        
        foreach(var element in arr)
        {
            if(element > maxElement)
            {
                maxElement = (long)element;
            }
            
            if(element < minElement)
            {
                minElement = (long)element;
            }
        }
        
        long minSum = 0;
        long maxSum = 0;
        
        bool minIsSkipped = false;
        bool maxIsSkipped = false;
        
        foreach(var element in arr)
        {
            if(element == maxElement)
            {
                if(!maxIsSkipped)
                {
                    maxIsSkipped = true;
                    continue;
                }
            }
            
            minSum+=element;
        }
        
        foreach(var element in arr)
        {
            if(element == minElement)
            {
                if(!minIsSkipped)
                {
                    minIsSkipped = true;
                    continue;
                }
            }
            
            maxSum+=element;
        }
        
        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
