using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> circlesToScan = new List<string>
            {
                "circle1.png",
                "circle2.png"
            };

            foreach (string circlePath in circlesToScan)
            {
                Console.WriteLine(CircleScanner.ScanCircle(circlePath));
            }

            Console.ReadLine();
        }
    }
}
