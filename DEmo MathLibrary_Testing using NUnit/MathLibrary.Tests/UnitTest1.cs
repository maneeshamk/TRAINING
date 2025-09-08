// importing Nunit framework and our application
using NUnit.Framework;
using DEmo_MathLibrary_Testing_using_NUnit; // added this as reference

namespace MathLibrary.Tests
{
    public class calculatorTests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator(); //allocating memory using new
        }


        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            //Assert.Pass(); for passing the flow of execution
            int result = calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
    }
       
        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Assert.Pass();
            int result = calculator.Sub(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}