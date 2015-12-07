using GenericsExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class ItemCatalogue<T> where T : Item
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public List<T> GetAllItems()
        {
            return items;
        }
    }
}
