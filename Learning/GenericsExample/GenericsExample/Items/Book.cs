using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Items
{
    public class Book : Item
    {
        private int _numberOfPages;
        public int numberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }
    }
}
