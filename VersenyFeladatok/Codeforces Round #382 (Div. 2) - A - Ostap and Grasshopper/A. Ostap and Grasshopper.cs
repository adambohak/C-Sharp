By bohak.adi, contest: Codeforces Round #382 (Div. 2), problem: (A) Ostap and Grasshopper, Accepted, #
 ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostap_and_grasshopper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            string sor = Console.ReadLine();
            int g = 0;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                if (sor[i] == 'G')
                    g = i;
                if (sor[i] == 'T')
                    t = i;
            }
            if (t < g)
                k = -k;
            bool siker = false;
            while (g >= 0 && g < n)
            {
                if (sor[g] == 'T')
                {
                    Console.WriteLine("YES");
                    siker = true;
                    break;
                }
                else if (sor[g] == '#')
                {
                    Console.WriteLine("NO");
                    siker = true;
                    break;
                }
                g += k;
            }
            if (!siker)
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}