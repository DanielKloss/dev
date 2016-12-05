using System;
using System.Collections.Generic;
using System.Linq;

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
        public int hqDistance;
        public int realHqDistance;
        private Direction currentDirection = Direction.North;
        private Coordinate currentPosition = new Coordinate(0, 0);
        private List<Coordinate> allPositions;

        public DayOne()
        {
            allPositions = new List<Coordinate> { currentPosition };
        }

        public void FindHq(string[] input)
        {
            bool realHqFound = false;
            List<string> directions = SplitInstructions(input[0]);

            foreach (string direction in directions)
            {
                FindNewDirection(direction.Substring(0, 1));

                for (int i = 0; i < Convert.ToInt32(direction.Substring(1)); i++)
                {
                    currentPosition = FindNewPosition();

                    if (!realHqFound && allPositions.Contains(currentPosition))
                    {
                        realHqDistance = Math.Abs(currentPosition.x) + Math.Abs(currentPosition.y);
                        realHqFound = true;
                    }
                    else
                    {
                        allPositions.Add(currentPosition);
                    }
                }

                hqDistance = Math.Abs(currentPosition.x) + Math.Abs(currentPosition.y);
            }
        }

        private List<string> SplitInstructions(string input)
        {
            return input.Split(',').Select(x => x.Trim(' ')).ToList();
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
