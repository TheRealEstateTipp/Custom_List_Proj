using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddToListUnitTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<T> ourList = new CustomList<T>;
            int expected = 2;

            //Act
            ourList.Add(2);
            int actual = ourList[0];

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomList<T> ourList = new CustomList<T>;
            int expected = 6;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            int actual = ourList[2];

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void TestMethod3()
        {
            //Arrange
            CustomList<T> ourList = new CustomList<T>;
            int expected = 3;

            //Act
            int actual = ourList.Count;

            //Assert
            Asset.AreEqual(actual, expected);
        }

        [TestMethod]

        public void TestMethod4()
        {
            //Arrange
            CustomList<T> ourList = new CustomList<T>;
            int expected = 0;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(10);
            ourList.Add(12);

            int actual = ourList[6]

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]

        public void TestMethod5()
        {
            //Arrange
            CustomList<T> ourList = new CustomList<T>;
            int expected = 6;

            //Act
            ourList.Add(2);
            ourList.Add(4);
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(10);
            ourList.Add(12);

            int actual = ourList.Count



            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
