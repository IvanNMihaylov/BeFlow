using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleVsBrown
{
    class Methods
    {
        private static int PurpleOccurCounter { get; set; }
        
        private static bool IsPurple(int x, int y)
        {
            int gridWidth = Cell.Cells.GetLength(0);  // get grid width
            int gridHeight = Cell.Cells.GetLength(1);  // get grid height

            if (x < 0 || x >= gridWidth)  // check if the point coordinates are out of the grid 
            {
                return false;  // 0
            }
            else if (y < 0 || y >= gridHeight)
            {
                return false; // 0 
            }


            return Cell.Cells[x, y] == 1 ? true : false; // if cell = 1(purple) return 1 (true)
        }

        private static int GetPurplesNeighborsCount(int x, int y)
        {
            int purpleCounter = 0;

            var upperLeftX = x - 1;
            var upperLeftY = y - 1;

            var upperCenterX = x;
            var upperCenterY = y - 1;

            var upperRightX = x + 1;
            var upperRightY = y - 1;

            var leftX = x - 1;
            var leftY = y;

            var rightX = x + 1;
            var rightY = y;

            var bottomLeftX = x - 1;
            var bottomLeftY = y + 1;

            var bottomCenterX = x;
            var bottomCenterY = y + 1;

            var bottomRightX = x + 1;
            var bottomRightY = y + 1;

            if (IsPurple(upperLeftX, upperLeftY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(upperCenterX, upperCenterY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(upperRightX, upperRightY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(leftX, leftY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(rightX, rightY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(bottomLeftX, bottomLeftY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(bottomCenterX, bottomCenterY))
            {
                purpleCounter += 1;
            }

            if (IsPurple(bottomRightX, bottomRightY))
            {
                purpleCounter += 1;
            }

            return purpleCounter;
        }

        private static int BrownToPurple(int x, int y)
        {
            //if 3 or 6 neighbors --> return 1
            List<int> purpleNeighborsCountRule = new List<int> { 3, 6 };

            int neigborsCount = GetPurplesNeighborsCount(x, y);

            if (purpleNeighborsCountRule.IndexOf(neigborsCount) > -1)
            {
                return 1;
            }
            return 0;
        }

        private static int PurpleToBrown(int x, int y)
        {
            //if 0,1,4,5,7,8 neighbors --> return 0
            List<int> purpleNeighborsCountRule = new List<int> { 0, 1, 4, 5, 7, 8 };

            int neigborsCount = GetPurplesNeighborsCount(x, y);

            if (purpleNeighborsCountRule.IndexOf(neigborsCount) > -1)
            {
                return 0;
            }
            return 1;
        }

        public void ApplyRules(int x, int y)
        {
            int newValue = Cell.Cells[x, y] == 1 ?
                PurpleToBrown(x, y) : BrownToPurple(x, y);

            Cell.Cells[x, y] = newValue;
            AddGeneration(newValue);
        }

        public void NextGeneration(int n)
        {
            for (int x = 0; x < Cell.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cell.Cells.GetLength(1); y++)
                {
                    if (n-- != 0)       // checks  (n != 0) then n = n-1;
                    {
                        ApplyRules(x, y);
                    }
                }
            }
        }

        public void AddGeneration(int value)
        {
            if (value == 1)
            {
                PurpleOccurCounter += 1;
            }
        }

    }
}
