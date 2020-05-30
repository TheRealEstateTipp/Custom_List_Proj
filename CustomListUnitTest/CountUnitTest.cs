using System;
using System.Runtime.Remoting;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class CountUnitTest
    {
        [TestMethod]
        public void Count_PositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 1;

            //Act
            newList.Add(2);

            actual = newList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Count_AddElements_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 4;

            //Act
            newList.Add(2);
            newList.Add(4);
            newList.Add(6);
            newList.Add(8);

            actual = newList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Count_AddStringPositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<string> newList = new CustomList<string>();
            int actual;
            int expected = 3;

            //Act
            newList.Add("Apple");
            newList.Add("Banana");
            newList.Add("Orange");

            actual = newList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Count_EmptyList_ReturnZero()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual; 
            int expected = 0;

            //Act
            
            actual = newList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
