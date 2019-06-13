using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nev = Console.ReadLine().Split(' ');
            string egyik = nev[0], masik = nev[1];
            StringBuilder sol = new StringBuilder();

            sol.Append(nev[0][0]);
            int i = 1;
            while (i < egyik.Length && egyik[i] < masik[0])
            {
                sol.Append(egyik[i]);
                i++;
            }
            sol.Append(masik[0]);
            Console.WriteLine(sol);
            Console.ReadLine();
        }
    }
}