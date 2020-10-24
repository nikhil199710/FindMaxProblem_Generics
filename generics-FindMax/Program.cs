using System;

namespace FindMaxProblem
{
    class Program
    {
        /// <summary>
        /// Implementing different methods from different classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to find max problem");
            //used to catch exception
            try
            {
                //Calling non generic method to find max of 3 integers
                int maxInt = NonGenericClass.MaxIntegerNumberAmongThree(23, 24, 22);
                Console.WriteLine("max integer value is\t" + maxInt);
                //calling non generic method to find max of 3 floats
                float maxFloat = NonGenericClass.MaxfloatNumberAmongThree(23, 24, 22);
                Console.WriteLine("max float value is\t" + maxFloat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}