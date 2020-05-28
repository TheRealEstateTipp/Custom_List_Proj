using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj    
{
    public class CustomList<T>
    {
        private T[] items;
        public int Count;
        public int Capacity;

        public CustomList()
        {
            items = new T[4];
            Count = 0;
            Capacity = 4;
        }

        public void Add(T item)
        {
            //add objects into array
            //If Count <= Capacity
            //Increase Capacity if Count is = Capacity
            //Get items copied to new array

            if (Count == Capacity)
            {
                T[] tempArray = new T[Capacity * 2];

                for (int i = 0; i < Capacity; i++)
                {
                    tempArray[i] = items[i];
                   
                }
                
                Capacity *= 2;

                items = tempArray;
            }

            items[Count] = item;
            Count++;
        }
    }

       
}
