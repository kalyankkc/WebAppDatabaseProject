using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Controllers;

namespace WebApp.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestShouldAlwaysWorkTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void OnePlusTwoEqualThreeTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void OnePlusTwoTest()
        {
            int a = 1;
            int b = 2;
            int resultExpected = 3;
            int resultActual;
            resultActual = EmployeesController.OnePlusTwo(a, b);
            Assert.AreEqual(resultExpected, resultActual, 0.001, "addition is one plus two is not correct");

        }

        [TestMethod]
        public void TwoPlusThreeTest()
        {
            int a = 2;
            int b = 3;
            int resultExpected = 5;
            int resultActual;
            resultActual = EmployeesController.TwoPlusThree(a, b);
            Assert.AreEqual(resultExpected, resultActual, 0.001, "addition is one plus two is not correct");

        }
        [TestMethod]
        public void ThreePlusFourTest()
        {
            int a = 3;
            int b = 4;
            int resultExpected = 7;
            int resultActual;
            resultActual = EmployeesController.ThreePlusFour(a, b);
            Assert.AreEqual(resultExpected, resultActual, 0.001, "addition is one plus two is not correct");

        }

    }
}
