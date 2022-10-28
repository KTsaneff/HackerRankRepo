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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string output = string.Empty;
        int hours = int.Parse(s.Substring(0,2));
        bool isAM = s.Substring(8,2) == "AM";
        
        if(isAM)
        {
            if(hours == 12)
            {
                return $"00:{s.Substring(3, 5)}";
            }
            return s.Substring(0, 8);
        }
        
        if(hours == 12)
        {
            return s.Substring(0, 8);
        }
        
        return $"{(hours + 12).ToString()}{s.Substring(2, 6)}";  
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
