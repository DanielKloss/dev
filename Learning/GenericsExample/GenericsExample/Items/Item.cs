using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Items
{
    public abstract class Item
    {
        private int _uniqueId;
        public int uniqueId
        {
            get { return _uniqueId; }
            set { _uniqueId = value; }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _price;
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
