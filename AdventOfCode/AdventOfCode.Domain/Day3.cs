using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class Day3
    {
        public int santaX;
        public int santaY;
        public int robotX;
        public int robotY;
        List<Tuple<int, int>> santaHouses;
        List<Tuple<int, int>> robotHouses;
        public int housesDeliveredTo;

        public Day3()
        {
            santaHouses = new List<Tuple<int, int>>();
            robotHouses = new List<Tuple<int, int>>();
            santaX = 0;
            santaY = 0;
            robotX = 0;
            robotY = 0;
            santaHouses.Add(new Tuple<int, int>(santaX, santaY));
            robotHouses.Add(new Tuple<int, int>(robotX, robotY));
        }

        public void MoveSanta(char instruction)
        {
            switch (instruction)
            {
                case '>':
                    santaX++;
                    break;
                case '<':
                    santaX--;
                    break;
                case '^':
                    santaY++;
                    break;
                case 'v':
                    santaY--;
                    break;
                default:
                    break;
            }

            santaHouses.Add(new Tuple<int, int>(santaX, santaY));
        }

        public void MoveRobot(char instruction)
        {
            switch (instruction)
            {
                case '>':
                    robotX++;
                    break;
                case '<':
                    robotX--;
                    break;
                case '^':
                    robotY++;
                    break;
                case 'v':
                    robotY--;
                    break;
                default:
                    break;
            }

            robotHouses.Add(new Tuple<int, int>(robotX, robotY));
        }

        public void DeliverPresents(string instructions)
        {
            foreach (char instruction in instructions)
            {
                MoveSanta(instruction);
            }

            housesDeliveredTo = santaHouses.Distinct().Count();
        }

        public void DeliverPresentsWithRobot(string instructions)
        {
            int count = 0;

            foreach (char instruction in instructions)
            {
                if (count % 2 == 0)
                {
                    MoveSanta(instruction);
                }
                else
                {
                    MoveRobot(instruction);
                }

                count++;
            }

            santaHouses.AddRange(robotHouses);
            housesDeliveredTo = santaHouses.Distinct().Count();
        }
    }
}
