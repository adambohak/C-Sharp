﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Div._1_B.Zuma
{
    class Program
    {
        static int[] gemstones;
        static int n;
        static void Main(string[] args)
        {
            //StreamReader sr = new StreamReader("be.txt");
            n = int.Parse(Console.ReadLine());
            gemstones = new int[n];
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                gemstones[i] = (int.Parse(s[i]));
            }
            int[,] tabla = new int[n, n];
            for (int i = 0; i < n-1; i++)
            {
                tabla[i, i] = 1;
                tabla[i + 1, i] = 1;
            }
            tabla[n - 1, n - 1] = 1;
            for (int i = n-2; i >= 0; i--)
            {
                for (int j = i+1; j < n; j++)
                {
                    int min = int.MaxValue;
                    for (int k = i; k < j; k++)
                    {
                        if (tabla[i, k] + tabla[k + 1, j] < min)
                        {
                            min = tabla[i, k] + tabla[k + 1, j];
                        }
                    }
                    if (gemstones[i] == gemstones[j] && min > tabla[i + 1, j - 1])
                    {
                        min = tabla[i + 1, j - 1];
                    }
                    tabla[i, j] = min;
                }
            }
            Console.WriteLine(tabla[0,n-1]);
            Console.ReadLine();
        }
    }
}
