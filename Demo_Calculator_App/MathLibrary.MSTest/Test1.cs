// add our project as well as unit testing package

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo_Calculator_App;


namespace MathLibrary.MSTest
{
    [TestClass]
    public class Test1
    {
        private Calculator calculator = new Calculator(); // ref of a class

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator(); // instantiation or allocating memory to above ref 
        }


        [TestMethod]
        public void Add_ReturnsMultiply()
        {
            int result = calculator.Multiply(5, 5);
            Assert.AreEqual(25, result);

        }



        ////Arrange 
        //int a = 5, b = 15;
        ////Act
        //int result = Divide(a, b);
        ////Assert

        //Assert.AreEqual()


        [TestMethod]


        public void Add_ReturnsDivide()
        {
            int result = calculator.Divide(5, 5);
           Assert.AreEqual(1, result);


        }
    }
}
