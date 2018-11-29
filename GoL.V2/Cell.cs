using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL.V2
{
    class Cell
    {
        private bool isAlive;
        public bool IsAlive
        {
            get => isAlive;
            set => isAlive = value;
        }

        public bool Get(Cell[,] grid, int y, int x)
        {
            int liveCells = 0;

            if (x < grid.GetLength(0) - 1 && y < grid.GetLength(1) - 1)
            {
                if (grid[x + 1, y + 1].IsAlive == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y].IsAlive == true)
                    liveCells++;
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1].IsAlive == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1 && y > 0)
            {
                if (grid[x + 1, y - 1].IsAlive == true)
                    liveCells++;
            }
            if (x > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[x - 1, y + 1].IsAlive == true)
                    liveCells++;
            }
            if (x > 0 && y > 0)
            {
                if (grid[x - 1, y - 1].IsAlive == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[x - 1, y].IsAlive == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[x, y - 1].IsAlive == true)
                    liveCells++;
            }
            if (liveCells == 2 || liveCells == 3 && grid[x, y].IsAlive == true)
            {
                return true;
            }
            else if(liveCells == 3 && grid[x, y].IsAlive == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
