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

        public bool UnderPopCell(UpdateCell[,] grid, int y, int x)
        {
            int liveCells = 0;

            //Test area for connecting the grid on all sides.

            // Logic for looking from bottom right hand corner to upper left hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x >= grid.GetLength(1) - 1)
            {
                if (grid[0, 1].State == true)
                    liveCells++;
                if (grid[0, 0].State == true)
                    liveCells++;
                if (grid[1, 0].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from bottom left hand corner to upper right hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x <= 0)
            {
                if (grid[0, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[0, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //------------------------------------


            // Logic for looking from upper left hand corner to bottom right hand corner.
            //-------------------------------------
            if (y <= 0 && x <= 0)
            {
                if (grid[grid.GetLength(0) - 2, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from upper right hand corner bottom left hand corner.
            //-------------------------------------
            if (y <= 0 && x >= grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 2, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from top side of square to bottom side
            //--------------------------------------
            if (y == 0 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 1, x - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from bottom side of square to top side
            //--------------------------------------
            if (y == grid.GetLength(0) - 1 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[0, x - 1].State == true)
                    liveCells++;
                if (grid[0, x].State == true)
                    liveCells++;
                if (grid[0, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from left side of square to right side
            //--------------------------------------
            if (x == 0 && y > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y + 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from right side of square to the left side
            //--------------------------------------
            if (x == grid.GetLength(1) - 1 && y > 0 && y < grid.GetLength(0) - 1)
            {
                if (grid[y - 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y + 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // End of test area



            if (y < grid.GetLength(0) - 1 && x < grid.GetLength(1) - 1)
            {
                if (grid[y + 1, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1)
            {
                if (grid[y + 1, x].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(1) - 1)
            {
                if (grid[y, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1 && x > 0)
            {
                if (grid[y + 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, x + 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x > 0)
            {
                if (grid[y - 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[y - 1, x].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[y, x - 1].State == true)
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

        public bool SurviveCell(UpdateCell[,] grid, int y, int x)
        {
            int liveCells = 0;

            //Test area for connecting the grid on all sides.

            // Logic for looking from bottom right hand corner to upper left hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x >= grid.GetLength(1) - 1)
            {
                if (grid[0, 1].State == true)
                    liveCells++;
                if (grid[0, 0].State == true)
                    liveCells++;
                if (grid[1, 0].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from bottom left hand corner to upper right hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x <= 0)
            {
                if (grid[0, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[0, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //------------------------------------


            // Logic for looking from upper left hand corner to bottom right hand corner.
            //-------------------------------------
            if (y <= 0 && x <= 0)
            {
                if (grid[grid.GetLength(0) - 2, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from upper right hand corner bottom left hand corner.
            //-------------------------------------
            if (y <= 0 && x >= grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 2, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from top side of square to bottom side
            //--------------------------------------
            if (y == 0 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 1, x - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from bottom side of square to top side
            //--------------------------------------
            if (y == grid.GetLength(0) - 1 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[0, x - 1].State == true)
                    liveCells++;
                if (grid[0, x].State == true)
                    liveCells++;
                if (grid[0, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from left side of square to right side
            //--------------------------------------
            if (x == 0 && y > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y + 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from right side of square to the left side
            //--------------------------------------
            if (x == grid.GetLength(1) - 1 && y > 0 && y < grid.GetLength(0) - 1)
            {
                if (grid[y - 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y + 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // End of test area


            if (y < grid.GetLength(0) - 1 && x < grid.GetLength(1) - 1)
            {
                if (grid[y + 1, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1)
            {
                if (grid[y + 1, x].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(1) - 1)
            {
                if (grid[y, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1 && x > 0)
            {
                if (grid[y + 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, x + 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x > 0)
            {
                if (grid[y - 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[y - 1, x].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[y, x - 1].State == true)
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

        public bool OverPopCell(UpdateCell[,] grid, int y, int x)
        {
            int liveCells = 0;

            //Test area for connecting the grid on all sides.

            // Logic for looking from bottom right hand corner to upper left hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x >= grid.GetLength(1) - 1)
            {
                if (grid[0, 1].State == true)
                    liveCells++;
                if (grid[0, 0].State == true)
                    liveCells++;
                if (grid[1, 0].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from bottom left hand corner to upper right hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x <= 0)
            {
                if (grid[0, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[0, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //------------------------------------


            // Logic for looking from upper left hand corner to bottom right hand corner.
            //-------------------------------------
            if (y <= 0 && x <= 0)
            {
                if (grid[grid.GetLength(0) - 2, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from upper right hand corner bottom left hand corner.
            //-------------------------------------
            if (y <= 0 && x >= grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 2, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from top side of square to bottom side
            //--------------------------------------
            if (y == 0 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 1, x - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from bottom side of square to top side
            //--------------------------------------
            if (y == grid.GetLength(0) - 1 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[0, x - 1].State == true)
                    liveCells++;
                if (grid[0, x].State == true)
                    liveCells++;
                if (grid[0, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from left side of square to right side
            //--------------------------------------
            if (x == 0 && y > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y + 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from right side of square to the left side
            //--------------------------------------
            if (x == grid.GetLength(1) - 1 && y > 0 && y < grid.GetLength(0) - 1)
            {
                if (grid[y - 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y + 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // End of test area



            if (y < grid.GetLength(0) - 1 && x < grid.GetLength(1) - 1)
            {
                if (grid[y + 1, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1)
            {
                if (grid[y + 1, x].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(1) - 1)
            {
                if (grid[y, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1 && x > 0)
            {
                if (grid[y + 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, x + 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x > 0)
            {
                if (grid[y - 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[y - 1, x].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[y, x - 1].State == true)
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

        public bool ReviveCell(UpdateCell[,] grid, int y, int x)
        {
            int liveCells = 0;

            //Test area for connecting the grid on all sides.

            // Logic for looking from bottom right hand corner to upper left hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x >= grid.GetLength(1) - 1)
            {
                if (grid[0, 1].State == true)
                    liveCells++;
                if (grid[0, 0].State == true)
                    liveCells++;
                if (grid[1, 0].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from bottom left hand corner to upper right hand corner.
            //-------------------------------------
            if (y >= grid.GetLength(0) - 1 && x <= 0)
            {
                if (grid[0, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[0, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //------------------------------------


            // Logic for looking from upper left hand corner to bottom right hand corner.
            //-------------------------------------
            if (y <= 0 && x <= 0)
            {
                if (grid[grid.GetLength(0) - 2, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 2].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from upper right hand corner bottom left hand corner.
            //-------------------------------------
            if (y <= 0 && x >= grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 2, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 0].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, 1].State == true)
                    liveCells++;
            }
            //-------------------------------------


            // Logic for looking from top side of square to bottom side
            //--------------------------------------
            if (y == 0 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[grid.GetLength(0) - 1, x - 1].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x].State == true)
                    liveCells++;
                if (grid[grid.GetLength(0) - 1, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from bottom side of square to top side
            //--------------------------------------
            if (y == grid.GetLength(0) - 1 && x > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[0, x - 1].State == true)
                    liveCells++;
                if (grid[0, x].State == true)
                    liveCells++;
                if (grid[0, x + 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from left side of square to right side
            //--------------------------------------
            if (x == 0 && y > 0 && y < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y, grid.GetLength(1) - 1].State == true)
                    liveCells++;
                if (grid[y + 1, grid.GetLength(1) - 1].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // Logic for looking from right side of square to the left side
            //--------------------------------------
            if (x == grid.GetLength(1) - 1 && y > 0 && y < grid.GetLength(0) - 1)
            {
                if (grid[y - 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
                if (grid[y + 1, x - (grid.GetLength(1) - 1)].State == true)
                    liveCells++;
            }
            //--------------------------------------

            // End of test area



            if (y < grid.GetLength(0) - 1 && x < grid.GetLength(1) - 1)
            {
                if (grid[y + 1, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1)
            {
                if (grid[y + 1, x].State == true)
                    liveCells++;
            }
            if (x < grid.GetLength(1) - 1)
            {
                if (grid[y, x + 1].State == true)
                    liveCells++;
            }
            if (y < grid.GetLength(0) - 1 && x > 0)
            {
                if (grid[y + 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x < grid.GetLength(1) - 1)
            {
                if (grid[y - 1, x + 1].State == true)
                    liveCells++;
            }
            if (y > 0 && x > 0)
            {
                if (grid[y - 1, x - 1].State == true)
                    liveCells++;
            }
            if (y > 0)
            {
                if (grid[y - 1, x].State == true)
                    liveCells++;
            }
            if (x > 0)
            {
                if (grid[y, x - 1].State == true)
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