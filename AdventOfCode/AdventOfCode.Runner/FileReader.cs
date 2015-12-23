using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Runner
{
    public class FileReader
    {
        StreamReader reader = new StreamReader("DayTwoData.txt");
        StringBuilder sb = new StringBuilder();

        public string Read()
        {
            do
            {
                sb.Append(reader.ReadLine() + " ");
            }
            while (reader.Peek() != -1);

            return sb.ToString();
        }
    }
}