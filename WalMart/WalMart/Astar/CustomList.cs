using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart.Astar
{
    public class CustomList <T> : IEnumerable<T>
    {
        private T[] items = new T[0];
        


        public void addItem(T item)
        {
            Array.Resize(ref items, items.Count() + 1);
            items[items.Count() - 1] = item;
        }
       
        
        public void removeItem(T item)
        {
            items[Array.IndexOf(items, item)] = items[items.Count() - 1];
            Array.Resize(ref items, items.Count() - 1);
        }
       
        public IEnumerable<T> Count()
        {
            return items;
        }
        public int CountTotal()
        {
            int number = 0;
            for (int i = 0; i < items.Length; i++)
            {
                number += 1;
            }

            return number;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

       
    }
}
