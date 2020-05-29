using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class IndexerUnitTest
    {
        [TestMethod]
        public void Index_PositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);

            actual = newList[2];


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void Index_String_ReturnString()
        {
            //Arrange
            CustomList<string> newList = new CustomList<string>();
            string expected = "Apple";
            string actual;


            //Act
            newList.Add("Apple");

            actual = newList[0];

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]

        public void Index_SetIndexPositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int expected = 10;
            int actual;

            //Act
            newList[2] = 10;
            actual = newList[2];

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Index_OutofRangeException_ReturnExpectedException()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;

            //Act
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);

            //Assert
            actual = newList[4];
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Index_OutofRangeExceptiononEmptyList_ReturnExpectedException()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            int actual;

            //Act

            //Assert
            actual = newList[0];

        }



    }
}
