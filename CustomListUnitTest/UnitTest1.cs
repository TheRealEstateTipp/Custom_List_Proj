using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddToListUnitTesting
    {
        [TestMethod]
        public void AddMethod_PositiveNumberinFirstIndex_ReturnPositiveNumer()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>;
            int expected = 2;
            int actual;

            //Act
            ourList.Add(2);
            actual = ourList[0];

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddMethod_PositiveNumberInLastIndex_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>;
            int expected = 6;
            int actual;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            actual = ourList[2];

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void AddNumber_PositiveNumberinListCount_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>;
            int expected = 3;
            int actual;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            actual = ourList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void AddNumber_TestLastIndex_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>;
            int expected = 12;
            int actual;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(10);
            ourList.Add(12);

            actual = ourList[5]

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]

        public void AddMethod_PositiveNumnerinListCount_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>;
            int expected = 6;
            int actual;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(10);
            ourList.Add(12);

            actual = ourList.Count



            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
