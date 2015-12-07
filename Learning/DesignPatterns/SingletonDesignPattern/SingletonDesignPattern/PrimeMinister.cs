using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class PrimeMinister
    {
        private readonly static PrimeMinister _instance = new PrimeMinister();
        public static PrimeMinister Instance
        {
            get
            {
                return _instance;
            }
        }

        public string Name { get; set; }

        PrimeMinister()
        {
            Name = "David Cameron";
        }
    }
}
