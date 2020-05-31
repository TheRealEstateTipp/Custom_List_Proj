using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj    
{
    public class CustomList<T>
    {
        private T[] items;
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Out of Range");
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if(index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Out of Range");
                }
                else
                {
                    items[index] = value;
                }
            }
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public bool isRemoved;
 

        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
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
            count++;
        }

        public void Remove(T itemtoRemove)
        {
            //Remove objects from array
            //Remove the first occurence 
            //Return true if item is removed
            //Return false if not removed and not found
            //Make another copy of the array 

            T[] newArray = new T[Capacity];

            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(itemtoRemove))
                {
                    continue;
                }
                else
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            }

        }
        public override string ToString()
        {
            return items.ToString();
        }

    }


       
}
