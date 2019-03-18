using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLV2
{
    class UpdateGrid
    {
        private const int Height = 20;
        private const int Width = 20;
        private UpdateCell[,] originalGrid = new UpdateCell[Height, Width];
        private UpdateCell[,] newGrid = new UpdateCell[Height, Width];
        private string cell = "  ";
        UpdateCell uc = new UpdateCell();

        public void Run()
        {
            InitalizeGrid();
            Console.CursorVisible = false;
            bool running = true;
            while (running)
            {
                PrintGrid();
                ApplyRulesToNewGrid();
                ApplyChangesToNewGrid();
                originalGrid = newGrid;
                System.Threading.Thread.Sleep(30);
                Console.SetCursorPosition(0, 0);
            }
        }

        public void ApplyRulesToNewGrid()
        {
            for (int i = 0; i < originalGrid.GetLength(0); i++)
            {
                for (int k = 0; k < originalGrid.GetLength(1); k++)
                {
                    if (originalGrid[i, k].State == true)
                    {
                        newGrid[i, k].Survive = uc.SurviveCell(originalGrid, i, k);
                    }
                    else
                    {
                        newGrid[i, k].Revive = uc.ReviveCell(originalGrid, i, k);
                    }
                }
            }
        }

        public void ApplyChangesToNewGrid()
        {
            for (int i = 0; i < newGrid.GetLength(0); i++)
            {
                for (int k = 0; k < newGrid.GetLength(1); k++)
                {
                    if (newGrid[i, k].Survive == true)
                    {
                        newGrid[i, k].State = true;
                        newGrid[i, k].Survive = false;
                        newGrid[i, k].Age = originalGrid[i, k].Age + 1;
                    }
                    else if (newGrid[i, k].Revive == true)
                    {
                        newGrid[i, k].State = true;
                        newGrid[i, k].Revive = false;
                        newGrid[i, k].Age = 1;
                    }
                    else
                    {
                        newGrid[i, k].State = false;
                        newGrid[i, k].Age = 0;
                    }
                }
            }
        }

        public void PrintGrid()
        {
            for (int i = 0; i < originalGrid.GetLength(0); i++)
            {
                for (int k = 0; k < originalGrid.GetLength(1); k++)
                {
                    if (originalGrid[i, k].State == true)
                    {
                        if (originalGrid[i, k].Age < 5)
                        {
                            PrintCell(Console.BackgroundColor = ConsoleColor.DarkGreen);
                        }
                        else
                        {
                            PrintCell(Console.BackgroundColor = ConsoleColor.DarkGray);
                        }
                    }
                    else
                    {
                        Console.Write(this.cell);
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintCell(ConsoleColor cell)
        {
            Console.Write(this.cell);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void InitalizeGrid()
        {
            Random rnd = new Random();
            for (int i = 0; i < Height; i++)
            {
                for (int k = 0; k < Width; k++)
                {
                    originalGrid[i, k] = new UpdateCell
                    {
                        State = Convert.ToBoolean(rnd.Next(0, 2)),
                    };
                    newGrid[i, k] = new UpdateCell();
                }
            }
            /*
            originalGrid[0, 0].State = true;
            originalGrid[0, 1].State = true;
            originalGrid[0, 2].State = true;
            originalGrid[0, 3].State = false;
            originalGrid[0, 4].State = false;
            originalGrid[0, 5].State = false;
            originalGrid[0, 6].State = false;
            originalGrid[0, 7].State = false;
            originalGrid[0, 8].State = false;
            originalGrid[0, 9].State = false;
            originalGrid[1, 0].State = false;
            originalGrid[1, 1].State = false;
            originalGrid[1, 2].State = false;
            originalGrid[1, 3].State = false;
            originalGrid[1, 4].State = false;
            originalGrid[1, 5].State = false;
            originalGrid[1, 6].State = false;
            originalGrid[1, 7].State = false;
            originalGrid[1, 8].State = false;
            originalGrid[1, 9].State = false;
            originalGrid[2, 0].State = false;
            originalGrid[2, 1].State = false;
            originalGrid[2, 2].State = false;
            originalGrid[2, 3].State = false;
            originalGrid[2, 4].State = false;
            originalGrid[2, 5].State = false;
            originalGrid[2, 6].State = false;
            originalGrid[2, 7].State = false;
            originalGrid[2, 8].State = false;
            originalGrid[2, 9].State = false;
            originalGrid[3, 0].State = false;
            originalGrid[3, 1].State = false;
            originalGrid[3, 2].State = false;
            originalGrid[3, 3].State = false;
            originalGrid[3, 4].State = false;
            originalGrid[3, 5].State = false;
            originalGrid[3, 6].State = false;
            originalGrid[3, 7].State = false;
            originalGrid[3, 8].State = false;
            originalGrid[3, 9].State = false;
            originalGrid[4, 0].State = false;
            originalGrid[4, 1].State = false;
            originalGrid[4, 2].State = false;
            originalGrid[4, 3].State = false;
            originalGrid[4, 4].State = false;
            originalGrid[4, 5].State = false;
            originalGrid[4, 6].State = false;
            originalGrid[4, 7].State = false;
            originalGrid[4, 8].State = false;
            originalGrid[4, 9].State = false;
            originalGrid[5, 0].State = false;
            originalGrid[5, 1].State = false;
            originalGrid[5, 2].State = false;
            originalGrid[5, 3].State = false;
            originalGrid[5, 4].State = false;
            originalGrid[5, 5].State = false;
            originalGrid[5, 6].State = false;
            originalGrid[5, 7].State = false;
            originalGrid[5, 8].State = false;
            originalGrid[5, 9].State = false;
            originalGrid[6, 0].State = false;
            originalGrid[6, 1].State = false;
            originalGrid[6, 2].State = false;
            originalGrid[6, 3].State = false;
            originalGrid[6, 4].State = false;
            originalGrid[6, 5].State = true;
            originalGrid[6, 6].State = false;
            originalGrid[6, 7].State = false;
            originalGrid[6, 8].State = false;
            originalGrid[6, 9].State = false;
            originalGrid[7, 0].State = false;
            originalGrid[7, 1].State = false;
            originalGrid[7, 2].State = false;
            originalGrid[7, 3].State = false;
            originalGrid[7, 4].State = true;
            originalGrid[7, 5].State = false;
            originalGrid[7, 6].State = true;
            originalGrid[7, 7].State = false;
            originalGrid[7, 8].State = false;
            originalGrid[7, 9].State = false;
            originalGrid[8, 0].State = false;
            originalGrid[8, 1].State = false;
            originalGrid[8, 2].State = false;
            originalGrid[8, 3].State = true;
            originalGrid[8, 4].State = false;
            originalGrid[8, 5].State = true;
            originalGrid[8, 6].State = false;
            originalGrid[8, 7].State = true;
            originalGrid[8, 8].State = false;
            originalGrid[8, 9].State = false;
            originalGrid[9, 0].State = false;
            originalGrid[9, 1].State = false;
            originalGrid[9, 2].State = false;
            originalGrid[9, 3].State = false;
            originalGrid[9, 4].State = true;
            originalGrid[9, 5].State = false;
            originalGrid[9, 6].State = true;
            originalGrid[9, 7].State = false;
            originalGrid[9, 8].State = false;
            originalGrid[9, 9].State = false;
            originalGrid[10, 0].State = false;
            originalGrid[10, 1].State = false;
            originalGrid[10, 2].State = false;
            originalGrid[10, 3].State = false;
            originalGrid[10, 4].State = false;
            originalGrid[10, 5].State = true;
            originalGrid[10, 6].State = false;
            originalGrid[10, 7].State = false;
            originalGrid[10, 8].State = false;
            originalGrid[10, 9].State = false;

            originalGrid[11, 0].State = false;
            originalGrid[11, 1].State = false;
            originalGrid[11, 2].State = false;
            originalGrid[11, 3].State = false;
            originalGrid[11, 4].State = false;
            originalGrid[11, 5].State = false;
            originalGrid[11, 6].State = false;
            originalGrid[11, 7].State = false;
            originalGrid[11, 8].State = false;
            originalGrid[11, 9].State = false;

            originalGrid[12, 0].State = false;
            originalGrid[12, 1].State = false;
            originalGrid[12, 2].State = false;
            originalGrid[12, 3].State = false;
            originalGrid[12, 4].State = false;
            originalGrid[12, 5].State = false;
            originalGrid[12, 6].State = false;
            originalGrid[12, 7].State = false;
            originalGrid[12, 8].State = false;
            originalGrid[12, 9].State = false;

            originalGrid[13, 0].State = false;
            originalGrid[13, 1].State = false;
            originalGrid[13, 2].State = false;
            originalGrid[13, 3].State = false;
            originalGrid[13, 4].State = false;
            originalGrid[13, 5].State = false;
            originalGrid[13, 6].State = false;
            originalGrid[13, 7].State = false;
            originalGrid[13, 8].State = false;
            originalGrid[13, 9].State = false;

            originalGrid[14, 0].State = true;
            originalGrid[14, 1].State = true;
            originalGrid[14, 2].State = true;
            originalGrid[14, 3].State = false;
            originalGrid[14, 4].State = false;
            originalGrid[14, 5].State = false;
            originalGrid[14, 6].State = false;
            originalGrid[14, 7].State = false;
            originalGrid[14, 8].State = false;
            originalGrid[14, 9].State = false;
            */
        }
    }
}