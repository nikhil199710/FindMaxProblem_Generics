using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxProblem
{
    public class NonGenericClass
    {
        /// <summary>
        /// max of 3 integers using non generic method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static int MaxIntegerNumberAmongThree(int first, int second, int third)
        {
            Console.WriteLine("Maximum number");
            //compare to method is used to compare 2 numbers
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
        /// <summary>
        /// used to find max between 3 floats using non generic method
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static float MaxfloatNumberAmongThree(float first, float second, float third)
        {
            Console.WriteLine("Maximum number");
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
        /// <summary>
        /// used to find max between 3 strings.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static string MaxstringNumberAmongThree(string first, string second, string third)
        {
            //compare to in string, can be used. string will be converted into ascii no
            //"abc", "xyz"---> first, ascii value of a and x will be compared, if one  number is highest, it will return input of bigger here only.
            //"189","1889"--> it will give 189 as large
            Console.WriteLine("Maximum number");
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            throw new Exception("All 3 numbers are same");
        }
    }
}