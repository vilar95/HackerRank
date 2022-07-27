//Plus Minus

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
//Mini Max Sum

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
//Time Conversion

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
//    public static string timeConversion(string s)
//    {
//        bool sucesso = DateTime.TryParse(s, out DateTime time);
//        if(sucesso)
//        {
//            return time.ToString("HH:mm:ss");
//        }
//        return "Success";
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = Result.timeConversion(s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

//=====================================================================================
// Lonely integer

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
//    public static int lonelyinteger(List<int> a)
//    {
//        var result = 0;
//        foreach (int i in a)
//        {
//            result ^= i;

//        }
//        return result;



//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        int result = Result.lonelyinteger(a);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

//=====================================================================================
//Diagonal Difference

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
//    public static int diagonalDifference(List<List<int>> arr)
//    {
//        int aux1 = 0;
//        int aux2 = 0;
//        int i = 0;
//        int total = 0;
//        int l = arr.Count - 1;
//        List<int> diagonal1 = new();
//        List<int> diagonal2 = new();
//        do
//        {
//            if (arr[i][i] == arr[i][i])
//            {
//                diagonal1.Insert(i, arr[i][i]);
//                aux1 = diagonal1[i] + aux1;
//            }
//            if (arr[i][l] == arr[i][l])
//            {
//                diagonal2.Insert(i, arr[i][l]);
//                aux2 = diagonal2[i] + aux2;
//            }
//            i++;
//            l--;

//        } while (i < arr.Count);

//        if(aux1 > aux2)
//        {
//            total = aux1 - aux2;
//        }
//        if (aux1 < aux2)
//        {
//            total = aux2 - aux1;
//        }
//        if (aux1 == aux2)
//        {
//            total = aux1 - aux2;
//        }

//        return total;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<List<int>> arr = new List<List<int>>();

//        for (int i = 0; i < n; i++)
//        {
//            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//        }

//        int result = Result.diagonalDifference(arr);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

//=====================================================================================
//

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
//     * Complete the 'findNumber' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY arr
//     *  2. INTEGER k
//     */

//    public static string findNumber(List<int> arr, int k)
//    {
//        return arr.Any(element => element == k) ? "YES" : "NO";

//}

//class Solution
//{
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = new List<int>();

//            for (int i = 0; i < arrCount; i++)
//            {
//                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//                arr.Add(arrItem);
//            }

//            int k = Convert.ToInt32(Console.ReadLine().Trim());

//            string result = Result.findNumber(arr, k);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}

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
     * Complete the 'oddNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static List<int> oddNumbers(int l, int r)
    {
        List<int> result = new();
        for (int i = l; i <= r; i++)
        {
            if(i % 2 != 0)
            {
                result.Add(i);
            }
        }
            return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        int r = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> result = Result.oddNumbers(l, r);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

