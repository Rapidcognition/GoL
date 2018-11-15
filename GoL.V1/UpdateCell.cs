using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL.V1
{
    class UpdateCell
    {
        public bool State { get; set; }
        public int Age { get; set; }
        public bool Revive { get; set; }
        public bool Survive { get; set; }
        public bool underPop { get; set; }
        public bool overPop { get; set; }

        public bool UnderPop(UpdateCell[,] grid, int x, int y)
        {
            int liveCells = 0;
            if (x < grid.GetLength(0) - 1 && y < grid.GetLength(1) - 1)
            {
                if (grid[x + 1, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1 && y > 0)
            {
                if (grid[x + 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[x - 1, y + 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y > 0)
            {
                if (grid[x - 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[x - 1, y].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[x, y - 1].State == true)
                    liveCells++;
            }
            if (liveCells < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AliveCell(UpdateCell[,] grid, int x, int y)
        {
            int liveCells = 0;
            if (x < grid.GetLength(0) - 1 && y < grid.GetLength(1) - 1)
            {
                if (grid[x + 1, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1 && y > 0)
            {
                if (grid[x + 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[x - 1, y + 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y > 0)
            {
                if (grid[x - 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[x - 1, y].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[x, y - 1].State == true)
                    liveCells++;
            }
            if (liveCells == 2 || liveCells == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OverPop(UpdateCell[,] grid, int x, int y)
        {
            int liveCells = 0;
            if (x < grid.GetLength(0) - 1 && y < grid.GetLength(1) - 1)
            {
                if (grid[x + 1, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1 && y > 0)
            {
                if (grid[x + 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[x - 1, y + 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y > 0)
            {
                if (grid[x - 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[x - 1, y].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[x, y - 1].State == true)
                    liveCells++;
            }
            if (liveCells > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReviveCell(UpdateCell[,] grid, int x, int y)
        {
            int liveCells = 0;
            if (x < grid.GetLength(0) - 1 && y < grid.GetLength(1) - 1)
            {
                if (grid[x + 1, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1)
            {
                if (grid[x + 1, y].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(1) - 1)
            {
                if (grid[x, y + 1].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(0) - 1 && y > 0)
            {
                if (grid[x + 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[x - 1, y + 1].State == true)
                    liveCells++;
            }
            if (x > 0 && y > 0)
            {
                if (grid[x - 1, y - 1].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[x - 1, y].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[x, y - 1].State == true)
                    liveCells++;
            }
            if (liveCells == 3)
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