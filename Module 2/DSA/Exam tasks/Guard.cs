using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guards
{
    class Program
    {
        static void Main()
        {
            int[] mazeDimensions = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            int row = mazeDimensions[0];
            int col = mazeDimensions[1];
            long[,] maze = new long[row, col];
            int guardsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < guardsCount; i++)
            {
                string[] guardPositions = Console.ReadLine().Split();
                int guardRow = Int32.Parse(guardPositions[0]);
                int guardCol = Int32.Parse(guardPositions[1]);
                maze[guardRow, guardCol] = int.MaxValue;
                switch (guardPositions[2])
                {
                    case "L":
                        if (guardCol > 0 && maze[guardRow, guardCol - 1] == 0)
                        {
                            maze[guardRow, guardCol - 1] = 3;
                        }
                        break;

                    case "R":
                        if (guardCol + 1 < col && maze[guardRow, guardCol + 1] == 0)
                        {
                            maze[guardRow, guardCol + 1] = 3;
                        }
                        break;

                    case "U":
                        if (guardRow > 0 && maze[guardRow - 1, guardCol] == 0)
                        {
                            maze[guardRow - 1, guardCol] = 3;
                        }
                        break;

                    case "D":
                        if (guardRow + 1 < row && maze[guardRow + 1, guardCol] == 0)
                        {
                            maze[guardRow + 1, guardCol] = 3;
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maze[i, j] == 0)
                    {
                        maze[i, j] = 1;
                    }

                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        maze[i, j] += maze[i, j - 1];
                    }

                    else if (j == 0)
                    {
                        maze[i, j] += maze[i - 1, j];
                    }

                    else
                    {
                        maze[i, j] += Math.Min(maze[i - 1, j], maze[i, j - 1]);
                    }
                }
            }

            if (maze[row - 1, col - 1] > int.MaxValue)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(maze[row - 1, col - 1]);
            }
        }
    }
}
