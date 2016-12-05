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

            string[] _dayOnePuzzleInput = File.ReadAllLines(@"Inputs/DayOneInput.txt");
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
