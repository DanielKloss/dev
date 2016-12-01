using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode16.Domain
{
    public enum Direction
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    public struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }

    public class DayOne
    {
        private Direction currentDirection = Direction.North;
        private Coordinate currentPosition = new Coordinate(0, 0);
        private List<Coordinate> allPositions;

        public DayOne()
        {
            allPositions = new List<Coordinate> { currentPosition };
        }

        public int FindHqDistance(string input)
        {
            int totalVertical = 0;
            int totalHorizontal = 0;
            List<string> directions = SplitInstructions(input);

            foreach (string direction in directions)
            {
                FindNewDirection(direction.Substring(0, 1));
                int blocks = Convert.ToInt32(direction.Substring(1));

                switch (currentDirection)
                {
                    case Direction.North:
                        totalVertical += blocks;
                        break;
                    case Direction.East:
                        totalHorizontal += blocks;
                        break;
                    case Direction.South:
                        totalVertical -= blocks;
                        break;
                    case Direction.West:
                        totalHorizontal -= blocks;
                        break;
                    default:
                        break;
                }
            }

            return Math.Abs(totalVertical) + Math.Abs(totalHorizontal);
        }

        public int FindHqCoordinate(string input)
        {
            List<string> directions = SplitInstructions(input);

            foreach (string direction in directions)
            {
                FindNewDirection(direction.Substring(0, 1));

                for (int i = 0; i < Convert.ToInt32(direction.Substring(1)); i++)
                {
                    currentPosition = FindNewPosition();

                    if (allPositions.Contains(currentPosition))
                    {
                        return Math.Abs(currentPosition.x) + Math.Abs(currentPosition.y);
                    }
                    else
                    {
                        allPositions.Add(currentPosition);
                    }
                }
            }

            return 0;
        }

        private List<string> SplitInstructions(string input)
        {
            List<string> directions = new List<string>();
            List<string> instructions = input.Split(',').ToList();

            foreach (string instruction in instructions)
            {
                string cleanInstruction = instruction.Trim(' ');
                directions.Add(cleanInstruction);
            }

            return directions;
        }

        private void FindNewDirection(string instruction)
        {
            if (instruction == "R")
            {
                if (currentDirection == Direction.West)
                {
                    currentDirection = Direction.North;
                }
                else
                {
                    currentDirection = (Direction)currentDirection + 1;
                }
            }
            else if (instruction == "L")
            {
                if (currentDirection == Direction.North)
                {
                    currentDirection = Direction.West;
                }
                else
                {
                    currentDirection = (Direction)currentDirection - 1;
                }
            }
        }

        private Coordinate FindNewPosition()
        {
            switch (currentDirection)
            {
                case Direction.North:
                    return new Coordinate(currentPosition.x, currentPosition.y + 1);
                case Direction.East:
                    return new Coordinate(currentPosition.x + 1, currentPosition.y);
                case Direction.South:
                    return new Coordinate(currentPosition.x, currentPosition.y - 1);
                default:
                    return new Coordinate(currentPosition.x - 1, currentPosition.y);
            }
        }
    }
}
