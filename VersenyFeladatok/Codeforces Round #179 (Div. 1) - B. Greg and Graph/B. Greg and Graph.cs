using System;
using System.Collections.Generic;
//using System.IO;

namespace Greg_and_Graph
{
    class Program
    {
        static int n;
        static long[,] matrix;
        static int[] sorrend;
        static long[] eredmeny;
        static void Main(string[] args)
        {
            Beolvasas();
            FloydWarshall();
            for (int i = n - 1; i >= 0; i--)
                Console.Write(eredmeny[i] + " ");
            Console.ReadLine();
        }
        static void FloydWarshall()
        {
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Math.Min(matrix[i, j],
                            matrix[i, sorrend[n - k - 1]] + matrix[sorrend[n - k - 1], j]);
                    }
                }
                long max = 0;
                for (int i = n - k - 1; i < n; i++)
                {
                    for (int j = n - k - 1; j < n; j++)
                    {
                        max += matrix[sorrend[i], sorrend[j]];
                    }
                }
                eredmeny[k] = max;
            }
        }
        static void Beolvasas()
        {
            //StreamReader sr = new StreamReader("be.txt");
            n = int.Parse(Console.ReadLine());
            matrix = new long[n, n];
            eredmeny = new long[n];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = long.Parse(s[j]);
                }
            }
            sorrend = new int[n];
            string[] s1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                sorrend[i] = int.Parse(s1[i]) - 1;
            }
        }
    }
}