using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class CapacityUnitTest
    {
        [TestMethod]
        public void Capacity_PositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 4;

            //Act
            newList.Add(2);

            actual = newList.Capacity;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Capacity_AddElements_ReturnPositiveNumber()
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

            actual = newList.Capacity;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Capacity_AddStringPositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<string> newList = new CustomList<string>();
            int actual;
            int expected = 4;

            //Act
            newList.Add("Apple");
            newList.Add("Banana");
            newList.Add("Orange");

            actual = newList.Capacity;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Capacity_EmptyList_ReturnZero()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;
            int expected = 8;

            //Act
            newList.Add(2);
            newList.Add(4);
            newList.Add(6);
            newList.Add(8);
            newList.Add(10);

            actual = newList.Capacity;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

