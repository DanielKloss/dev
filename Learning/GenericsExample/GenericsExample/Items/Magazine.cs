using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Items
{
    public class Magazine : Item
    {
        private string _advert;
        public string advert
        {
            get { return _advert; }
            set { _advert = value; }
        }
    }
}
