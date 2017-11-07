using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestKeyboardInput() // press g
        {
            //Arrange
            string choosedLetter;
            string expected = "g";
            //Act
            choosedLetter = Convert.ToString(Console.ReadKey().KeyChar);
            //Assert
            Assert.AreEqual(choosedLetter, expected);
        }
    }
}
