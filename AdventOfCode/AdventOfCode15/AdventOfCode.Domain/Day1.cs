
namespace AdventOfCode.Domain
{
    public class Day1
    {
        public int floor { get; set; }
        public bool basementFound { get; set; }
        public int basementInstruction { get; set; }

        public Day1()
        {
            floor = 0;
            basementFound = false;
            basementInstruction = 0;
        }

        public void FindFloor(string instructions)
        {
            int index = 1;

            foreach (char instruction in instructions)
            {
                if (instruction == '(')
                {
                    floor++;
                }
                else if (instruction == ')')
                {
                    floor--;

                    if (floor == -1 && !basementFound)
                    {
                        basementInstruction = index;
                        basementFound = true;
                    }
                }

                index++;
            }
        }
    }
}