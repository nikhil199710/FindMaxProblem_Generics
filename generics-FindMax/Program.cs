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
                //calling non generic method to find max of 3 strings
                string maxString = NonGenericClass.MaxstringNumberAmongThree("23", "24", "22");
                Console.WriteLine("max string value is\t" + maxString);
                //using generic class to print max of 3 numbers
                int maxFromGeneric = GenericClass<int>.MaxAmongThree(23, 45, 555);
                Console.WriteLine("max from generic\t" + maxFromGeneric);

                //using parametrized constructor
                GenericClass<float> genericClass = new GenericClass<float>(45.5f, 4555.5f, 4.5f, 4444444f, 543f);
                //Object can not call static method directly, so get method is called in which passes parameter values to static method
                //float max = genericClass.GetMethod();
                //Console.WriteLine("max from using parametrized constructor\t" + max);
                //for removing the defining of another variable of same datatype, method is called to print result in generic class
                genericClass.printMaxGenericMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}