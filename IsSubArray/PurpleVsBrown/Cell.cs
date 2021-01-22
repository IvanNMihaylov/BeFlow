using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleVsBrown
{
    class Cell
    {
        private int x;
        private int y;
        public static int[,] Cells { get; set; }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }


    }
}
