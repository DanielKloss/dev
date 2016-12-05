using AdventOfCode16.Domain;
using System;
using System.IO;

namespace AdventOfCode16.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOne();

            DayTwo();

            DayThree();

            Console.ReadLine();
        }

        private static void Divider()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        private static void DayOne()
        {
            Console.WriteLine();
            Console.WriteLine("*** DAY ONE ***");
            Console.WriteLine();

            string _dayOnePuzzleInput = "L5, R1, R3, L4, R3, R1, L3, L2, R3, L5, L1, L2, R5, L1, R5, R1, L4, R1, R3, L4, L1, R2, R5, R3, R1, R1, L1, R1, L1, L2, L1, R2, L5, L188, L4, R1, R4, L3, R47, R1, L1, R77, R5, L2, R1, L2, R4, L5, L1, R3, R187, L4, L3, L3, R2, L3, L5, L4, L4, R1, R5, L4, L3, L3, L3, L2, L5, R1, L2, R5, L3, L4, R4, L5, R3, R4, L2, L1, L4, R1, L3, R1, R3, L2, R1, R4, R5, L3, R5, R3, L3, R4, L2, L5, L1, L1, R3, R1, L4, R3, R3, L2, R5, R4, R1, R3, L4, R3, R3, L2, L4, L5, R1, L4, L5, R4, L2, L1, L3, L3, L5, R3, L4, L3, R5, R4, R2, L4, R2, R3, L3, R4, L1, L3, R2, R1, R5, L4, L5, L5, R4, L5, L2, L4, R4, R4, R1, L3, L2, L4, R3";
            DayOne dayOne = new DayOne();
            dayOne.FindHq(_dayOnePuzzleInput);
            Console.WriteLine(string.Format("The Easter Bunny's HQ is {0} blocks away", dayOne.hqDistance));
            Console.WriteLine(string.Format("The Easter Bunny's HQ is actually in reality {0} blocks away", dayOne.realHqDistance));
            Divider();
        }

        private static void DayTwo()
        {
            Console.WriteLine();
            Console.WriteLine("*** DAY TWO ***");
            Console.WriteLine();

            string[] _dayTwoPuzzleInput = File.ReadAllLines(@"Inputs/DayTwoInput.txt");
            DayTwo dayTwo = new DayTwo();
            string code = dayTwo.FindToiletCode(_dayTwoPuzzleInput);
            string realCode = dayTwo.FindRealToiletCode(_dayTwoPuzzleInput);
            Console.WriteLine(string.Format("The code for the toilet is {0}", code));
            Console.WriteLine(string.Format("The real code for the toilet is actually in reality {0}", realCode));
            Divider();
        }

        private static void DayThree()
        {
            Console.WriteLine();
            Console.WriteLine("*** DAY THREE ***");
            Console.WriteLine();

            string[] _dayThreePuzzleInput = File.ReadAllLines(@"Inputs/DayThreeInput.txt");
            DayThree dayThree = new DayThree();
            int triangles = dayThree.CheckTriangles(_dayThreePuzzleInput);
            int verticalTriangles = dayThree.CheckTrianglesVertically(_dayThreePuzzleInput);
            Console.WriteLine(string.Format("There are {0} possible triangles", triangles));
            Console.WriteLine(string.Format("There are {0} possible vertical triangles", verticalTriangles));
            Divider();
        }
    }
}
