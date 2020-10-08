using System;
using System.Net.Security;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira, respectivamente, o número de linhas e colunas: ");
            string[] matDimensions = Console.ReadLine().Split(' ');

            int line = int.Parse(matDimensions[0]);
            int column = int.Parse(matDimensions[1]);

            int[,] mat = new int[line, column];

            for(int i = 0; i < line; i++)
            {
                string[] lines = Console.ReadLine().Split(' ');
                for(int j = 0; j < column; j++)
                {
                    mat[i, j] = int.Parse(lines[j]);
                }
            }

            Console.Write("Insira o número que deseja localizar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mat[i, j] == n)
                    {
                        Console.WriteLine($"Posição: {i}, {j}");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                        Console.WriteLine("----------x----------");
                    }
                }
            }
        }
    }
}
