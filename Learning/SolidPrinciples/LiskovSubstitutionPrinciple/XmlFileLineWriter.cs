using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class XmlFileLineWriter : FileLineWriter
    {
        public override void Write(string line)
        {
            //This is wrong, this is not what we expect the method to do...
            //Console.WriteLine("Deleting line from file");

            Console.WriteLine("Writing line to XML file...");
        }
    }
}
