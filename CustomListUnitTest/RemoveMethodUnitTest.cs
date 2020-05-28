using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class RemoveMethodUnitTest   
    {
        [TestMethod]
        public void Remove_LastElementRemoved_ReturnZero()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            int expected = 0;
            int actual;


            //Act
            ourList.Add(2);
            ourList.Remove(2);

            actual = ourList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]

        public void Remove_PositiveNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            int expected = 6;
            int actual;


            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);

            ourList.Remove(4);

            actual = ourList[1];


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Remove_String_ReturnString()
        {
            //Arrange
            CustomList<string> ourList = new CustomList<string>();
            string expected = "Oranges";
            string actual;

            //Act
            ourList.Add("Apples");
            ourList.Add("Bananas");
            ourList.Add("Oranges");

            ourList.Remove("Apples");

            actual = ourList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_GroupofSameNumber_ReturnPositiveNumber()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            int expected = 3;
            int actual;


            //Act
            ourList.Add(5);
            ourList.Add(5);
            ourList.Add(5);
            ourList.Add(5);

            ourList.Remove(5);

            actual = ourList.Count;


            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]

        public void Remove_ElementNotInList_BooleanReturn()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            bool expected = false;
            bool actual;


            //Act
            ourList.Add(5);
            ourList.Add(5);
            ourList.Add(5);
            ourList.Add(5);

            actual = ourList.Remove(10);

   
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
