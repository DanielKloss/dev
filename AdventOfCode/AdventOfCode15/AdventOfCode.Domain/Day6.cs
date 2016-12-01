using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class Day6
    {
        public List<List<bool>> grid;
        public List<List<int>> brightnessGrid;
        public List<string> splitList;
        private int startRow = 0;
        private int endRow = 0;
        private int startColumn = 0;
        private int endColumn = 0;

        public void CreateGrid()
        {
            grid = new List<List<bool>>();

            for (int i = 0; i < 1000; i++)
            {
                grid.Add(new List<bool>());
            }

            foreach (List<bool> row in grid)
            {
                for (int i = 0; i < 1000; i++)
                {
                    row.Add(false);
                }
            }
        }

        public void CreateBrightnessGrid()
        {
            brightnessGrid = new List<List<int>>();

            for (int i = 0; i < 1000; i++)
            {
                brightnessGrid.Add(new List<int>());
            }

            foreach (List<int> row in brightnessGrid)
            {
                for (int i = 0; i < 1000; i++)
                {
                    row.Add(0);
                }
            }
        }

        public List<List<bool>> CreateTestGrid()
        {
            grid = new List<List<bool>>();

            for (int i = 0; i < 1000; i++)
            {
                grid.Add(new List<bool>());
            }

            foreach (List<bool> row in grid)
            {
                for (int i = 0; i < 1000; i++)
                {
                    row.Add(false);
                }
            }

            return grid;
        }

        private void ConvertCoordinates(string startInput, string endInput)
        {
            startRow = Convert.ToInt32(startInput.Split(',').First());
            endRow = Convert.ToInt32(endInput.Split(',').First());
            startColumn = Convert.ToInt32(startInput.Split(',').Last());
            endColumn = Convert.ToInt32(endInput.Split(',').Last());
        }

        public void TurnOnLights(string startInput, string endInput)
        {
            ConvertCoordinates(startInput, endInput);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    grid[i][j] = true;
                    brightnessGrid[i][j]++;
                }
            }
        }

        public void TurnOffLights(string startInput, string endInput)
        {
            ConvertCoordinates(startInput, endInput);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    grid[i][j] = false;

                    if (brightnessGrid[i][j] > 0)
                    {
                        brightnessGrid[i][j]--;
                    }
                }
            }
        }

        public void ToggleLights(string startInput, string endInput)
        {
            ConvertCoordinates(startInput, endInput);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    grid[i][j] = !grid[i][j];
                    brightnessGrid[i][j] += 2;
                }
            }
        }

        public void SplitInput(string testInput)
        {
            string[] splitArray = testInput.Split(' ');
            splitList = splitArray.ToList();

            if (splitList.Count > 4)
            {
                splitList[0] = splitList[0] + " " + splitList[1];
                splitList.RemoveAt(1);
            }
        }

        public void LightRouter()
        {
            if (splitList[0] == "turn on")
            {
                TurnOnLights(splitList[1], splitList[3]);
            }
            else if (splitList[0] == "turn off")
            {
                TurnOffLights(splitList[1], splitList[3]);
            }
            else if (splitList[0] == "toggle")
            {
                ToggleLights(splitList[1], splitList[3]);
            }
        }

        public int CountNumberOfLightsOn()
        {
            int numberOfLightsOn = 0;

            foreach (List<bool> row in grid)
            {
                foreach (bool light in row)
                {
                    if (light)
                    {
                        numberOfLightsOn++;
                    }
                }
            }

            return numberOfLightsOn;
        }

        public int CalculateTotalBrightness()
        {
            int totalBrightness = 0;

            foreach (List<int> row in brightnessGrid)
            {
                foreach (int light in row)
                {
                    totalBrightness += light;
                }
            }

            return totalBrightness;
        }
    }
}
