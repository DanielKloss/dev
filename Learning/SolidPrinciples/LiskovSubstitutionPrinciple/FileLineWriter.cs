using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class FileLineWriter
    {
        public virtual void Write(string line)
        {
            Console.WriteLine("Writing Line to file...");
        }
    }
}
