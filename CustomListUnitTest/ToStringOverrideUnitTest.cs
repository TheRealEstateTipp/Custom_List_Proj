using System;
using System.Security.Cryptography.X509Certificates;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class ToStringOverrideUnitTest
    {
        [TestMethod]
        public void ToString_Integer_ReturnInteger()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();


            //Act
            newList.Add(24);

            Console.WriteLine(newList);
        }
    
        [TestMethod]
        public void ToString_String_ReturnString()
        {
             //Arrange
             CustomList<string> newList = new CustomList<string>();


             //Act
             newList.Add("Apples");

             Console.WriteLine(newList);
        }

         [TestMethod]
         public void ToString_Double_ReturnDouble()
         {
              //Arrange
              CustomList<double> newList = new CustomList<double>();

              //Act
              newList.Add(2.4);
              Console.WriteLine(newList);
         }

         [TestMethod]
         public void ToString_MultipleInt_ReturnMultipleInt()
         {
             //Arrange
             CustomList<int> newList = new CustomList<int>();
 
             //Act
             newList.Add(2);
             newList.Add(4);

             Console.WriteLine(newList);
         }

        [TestMethod]
        public void ToString_MultipleString_ReturnMultipleString()
        {
            //Arrange
            CustomList<string> newList = new CustomList<string>();


            //Act
            newList.Add("Apple");
            newList.Add("Banana");

            Console.WriteLine(newList);
        }
     
    }
}