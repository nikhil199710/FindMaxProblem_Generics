using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FindMaxProblem
{
    /// <summary>
    /// Generic class where datatype is defined
    /// in generic class, whenever a compare to method is defined, it's defining interface-IComparable neeeds to be inherited.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T> where T : IComparable
    {
        //defining variable of generic type
        T[] inputNumbers;

        /// <summary>
        /// parameter constructor to initialize variables
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public GenericClass(params T[] inputNumbers)
        {
            this.inputNumbers = inputNumbers;
        }

        /// <summary>
        /// Max among 3 is used to find out max by using generics, any data type can be provided
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static T MaxAmongThree(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
                return third;
            else
            {
                throw new Exception("All 3 numbers are same");
            }
        }
        /// <summary>
        /// used to sort a array which is created due to declaration of params
        /// params help to take any no of input and stores them an array dynamically without initializing and declaring no of inputs in it
        /// </summary>
        /// <param name="inputNumbers"></param>
        /// <returns></returns>
        public static T SortingOfNumbers(params T[] inputNumbers)
        {
            Array.Sort(inputNumbers);
            return inputNumbers[inputNumbers.Length - 1];
        }
        /// <summary>
        /// used to pass the values from parametrized constructor to MaxAmongThree static method
        /// static method can not be directly called using object
        /// //if variables are not passed to maxthreemethod from here and removed from parameters,
        /// then object reference will be needed to pass for every variable in method, means object will be created in class and instatiated for variables
        /// as variables are not static
        /// //which will be complicated process, hence maxamongthree is parametrized and parameters are passed through get method().
        /// </summary>
        /// <returns></returns>
        public T GetMethod()
        {
            T maximum = SortingOfNumbers(inputNumbers);
            return maximum;
        }
        /// <summary>
        /// used to print the result in generic class, so that another variable with datatype of T is not defined in main class
        /// </summary>
        public void printMaxGenericMethod()
        {
            T printingMaxValue = GetMethod();
            Console.WriteLine("max from using parametrized constructor\t" + printingMaxValue);
        }
    }
}