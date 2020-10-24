using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxProblem;
using System.Threading;

namespace findMaxMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Used to test MaxIntegers numbers among three from non generic class
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>

        [TestMethod]
        [DataRow(45, 47, 60, 60)]
        [DataRow(45, 122, 60, 122)]
        [DataRow(440, 47, 60, 440)]
        public void MaxFromThreeIntegers(int a, int b, int c, int expected)
        {
            //Arrange
            //add
            int actual = NonGenericClass.MaxIntegerNumberAmongThree(a, b, c);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// used to test max float no from three coming from non generic class
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(45.1f, 47.2f, 60.3f, 60.3f)]
        [DataRow(45.6f, 122.4f, 60.5f, 122.4f)]
        [DataRow(440.7f, 47.8f, 60.9f, 440.7f)]
        public void MaxFromThreeFloats(float a, float b, float c, float expected)
        {
            //Arrange
            //add
            float actual = NonGenericClass.MaxfloatNumberAmongThree(a, b, c);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// used to test max of string numbers coming from non generic class
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("45", "47", "60", "60")]
        [DataRow("1212", "122", "1160", "122")]
        [DataRow("440", "47", "60", "60")]
        public void MaxValuefromStrings(string a, string b, string c, string expected)
        {
            //Arrange
            //add
            string actual = NonGenericClass.MaxstringNumberAmongThree(a, b, c);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Validating generic method for int
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(43, 45, 66, 66)]
        public void MaxFromGenericForInt(int a, int b, int c, int expected)
        {
            //Arrange
            int actual = GenericClass<int>.MaxAmongThree(a, b, c);
            //assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// validating generic method for float input
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(43.4f, 45.5f, 66.7f, 66.7f)]
        public void MaxFromGenericForFloat(float a, float b, float c, float expected)
        {
            //Arrange
            float actual = GenericClass<float>.MaxAmongThree(a, b, c);
            //assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// validating generic method for string input
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("43.4", "122", "6.67", "6.67")]
        public void MaxFromGenericForString(string a, string b, string c, string expected)
        {
            //Arrange
            string actual = GenericClass<string>.MaxAmongThree(a, b, c);
            //assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Validating generic method for int using parametrized constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(43, 45, 66, 66)]
        public void MaxFromGenericForIntUsingParametrizedConstructor(int a, int b, int c, int expected)
        {
            //Arrange
            GenericClass<int> genericClass = new GenericClass<int>(a, b, c);
            //add
            int actual = genericClass.GetMethod();
            //assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// validating generic method for float input using parametrized constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow(43.4f, 45.5f, 66.7f, 66.7f)]
        public void MaxFromGenericForFloatUsingParametrizedConstructor(float a, float b, float c, float expected)
        {
            //Arrange
            GenericClass<float> genericClass = new GenericClass<float>(a, b, c);
            //add
            float actual = genericClass.GetMethod();
            //assert
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// validating generic method for string input using parametrized constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="expected"></param>
        [TestMethod]
        [DataRow("43.4", "122", "6.67", "6.67")]
        public void MaxFromGenericForStringusingparametrizedConstructor(string a, string b, string c, string expected)
        {
            //assert
            GenericClass<string> genericClass = new GenericClass<string>(a, b, c);
            //Add
            string actual = genericClass.GetMethod();
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [DataRow(5.6f, 2.3f, 112.3f, 223.5f, 323, 323)]

        public void MaxFromGenericWhenValuesArePassedWithparams(params float[] values)
        {
            //assert
            GenericClass<float> genericClass = new GenericClass<float>(values);
            float expected = 323;
            //add
            float actual = genericClass.GetMethod();
            //assert
            Assert.AreEqual(expected, actual);

        }
    }

}