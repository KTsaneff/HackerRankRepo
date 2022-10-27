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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positiveNumbersCount = 0;
        double zeroNumbersCount = 0;
        double negativeNumberCount = 0;
        
        foreach(var element in arr)
        {
            if(element > 0){ positiveNumbersCount++; }
            if(element == 0){ zeroNumbersCount++; }
            if(element < 0){ negativeNumberCount++; }
        }
        
        List<string> ratios = new List<string>(3);
        
        decimal positiveRatio = (decimal)(positiveNumbersCount/arr.Count);
        decimal zeroRatio = (decimal)(zeroNumbersCount/arr.Count);
        decimal negativeRatio = (decimal)(negativeNumberCount/arr.Count);
        
        ratios.Add(Math.Round(positiveRatio, 6).ToString("0.######"));
        ratios.Add(Math.Round(negativeRatio, 6).ToString("0.######"));
        ratios.Add(Math.Round(zeroRatio, 6). ToString("0.######"));
        
        Console.WriteLine(string.Join(Environment.NewLine, ratios));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
