﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLineWriter fileLineWriter = new XmlFileLineWriter();
            fileLineWriter.Write("Hello World");

            Console.ReadLine();
        }
    }
}