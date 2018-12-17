using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Custom_Generics
{
    class PractiseList<T>
    {
        private T[] items = new T[0];

        // return item @ index
        public T GetItems(int index) { return items[index]; }

        //Add an items to an existing array
        public void Add(T newItem)
        {
            T[] newItemList = new T[items.Length + 1];
            for (int i=0; i < items.Length; i++)
            {
                newItemList[i] = items[i];
            }
            newItemList[newItemList.Length - 1] = newItem;
            items = newItemList;
        }
    }
}
