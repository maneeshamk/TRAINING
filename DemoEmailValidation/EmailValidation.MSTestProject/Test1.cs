﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoEmailValidation;


namespace EmailValidation.MSTestProject
{
    [TestClass]
    public class Test1
    {
        private EmailValidator validator;

        [TestInitialize]
        public void TestInitialize()
        {
            validator = new EmailValidator();
        }



        [TestMethod]
        public void IsEmailValid_ShouldReturnFalseForInvalidEmail()
        {
            string input = "Invalid_email.com";
            bool result = validator.IsEmailValid(input);
            Assert.IsFalse(result); // we are checking for valid email value
        }

        public void IsEmailValid_ShouldReturTrueForValidEmail()
        {
            string input = "Valid@example.com";
            bool result = validator.IsEmailValid(input);
            Assert.IsTrue(result); // we are checking for valid email value
        }


    }
}
