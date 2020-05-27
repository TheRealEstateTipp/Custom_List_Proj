using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj    
{
    public class CustomList<T>
    {
        private T[] ourList;

        public CustomList()
        {
            ourList = new T[4];
        }

    }

       
}
