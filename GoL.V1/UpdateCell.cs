using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL.V1
{
    class UpdateCell
    {
        private int age;
        public int Age
        {
            get => age;
            set => age = value;
        }

        private bool state;
        public bool State
        {
            get => state;
            set => state = value;
        }

        private bool underPop;
        public bool UnderPop
        {
            get => underPop;
            set => underPop = value;
        }

        private bool survive;
        public bool Survive
        {
            get => survive;
            set => survive = value;
        }

        private bool overPop;
        public bool OverPop
        {
            get => overPop;
            set => overPop = value;
        }

        private bool revive;
        public bool Revive
        {
            get => revive;
            set => revive = value;
        }

        public bool UnderPopCell(UpdateCell[,] grid, int x, int y)
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

        public bool SurviveCell(UpdateCell[,] grid, int x, int y)
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

        public bool OverPopCell(UpdateCell[,] grid, int x, int y)
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