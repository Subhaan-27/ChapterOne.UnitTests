using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDesign;


namespace ChapterOne.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stringToCheck = "mysterious";

            var stringToFind = "y";

            var expectedResult = 1;

            var classUnderTest = new TestDesign.StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);
            
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestMethod]
        public void TestMethod2()
        {
            var stringToCheck = "mysterious";

            var stringToFind = "s";

            var expectedResult = 2;

            var classUnderTest = new TestDesign.StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var stringToCheck = "mySterious";

            var stringToFind = "s";

            var expectedResult = 2;

            var classUnderTest = new TestDesign.StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod4()
        {
            string stringToCheck = null;

            var stringToFind = "s";

            var expectedResult = -1;

            var classUnderTest = new TestDesign.StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind[0]);

            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}
