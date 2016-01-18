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
        StreamReader reader;
        StringBuilder sb;

        public string Read(string path)
        {
            reader = new StreamReader(path);
            sb = new StringBuilder();

            do
            {
                sb.Append(reader.ReadLine() + " ");
            }
            while (reader.Peek() != -1);

            return sb.ToString();
        }

        public string ReadWithLineBreak(string path)
        {
            reader = new StreamReader(path);
            sb = new StringBuilder();

            do
            {
                sb.Append(reader.ReadLine() + Environment.NewLine);
            }
            while (reader.Peek() != -1);

            return sb.ToString();
        }
    }
}