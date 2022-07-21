//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{

//    /*
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static void plusMinus(List<int> arr, int n)
//    {

//        float pos = 0;
//        float neg = 0;
//        float zero = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] > 0)
//            {
//                pos++;
//            }
//            else if (arr[i] < 0)
//            {
//                neg++;
//            }
//            else
//            {
//                zero++;
//            };

//        }

//        pos /= n;
//        neg /= n;
//        zero /= n;

//        Console.WriteLine($"{pos:0.000000}\n{neg:0.000000}\n{zero:0.000000}\n");

//        //Console.WriteLine(String.Join("\n", arr));
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.plusMinus(arr, n);

//    }
//}
//=====================================================================================

//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{
//    public static void miniMaxSum(List<int> arr)
//    {


//        var (maxValor, maxIndex) = arr.Select((x, i) => (x, i)).Max();
//        var (minValor, minIndex) = arr.Select((x, i) => (x, i)).Min();

//        int minVal = int.MaxValue;
//        foreach (int i in arr)
//        {
//            if (i <= minVal)
//            {
//                minVal = i;
//            }
//        }
//        int maxVal = int.MinValue;
//        foreach (int i in arr)
//        {
//            if (i >= maxVal)
//            {
//                maxVal = i;
//            }
//        }


//        var total = arr.Sum(x => Convert.ToInt64(x));

//        var somaMini = total - maxValor;
//        var somaMax = total - minVal;
//        Console.WriteLine(string.Format("{0} {1}", somaMini, somaMax));
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(
//            arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.miniMaxSum(arr);

//    }
//}

//=====================================================================================

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
    public static string timeConversion(string s)
    {

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
