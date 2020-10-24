using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxProblem;

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
    }
}