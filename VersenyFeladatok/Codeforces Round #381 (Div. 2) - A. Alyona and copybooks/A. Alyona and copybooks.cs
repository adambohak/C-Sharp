using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alyona_and_copybooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long n = long.Parse(s[0]);
            long a = long.Parse(s[1]);
            long b = long.Parse(s[2]);
            long c = long.Parse(s[3]);
            long am = 0;
            long k = 4 - (n % 4);
            if (k == 1)
            {
                if (Math.Min(c * 3, c + b) > a)
                {
                    am += a;
                }
                else
                    am += Math.Min(c * 3, c + b);
            }
            else if (k == 2)
            {
                if (Math.Min(a * 2, 2 * c) > b)
                {
                    am += b;
                }
                else
                    am += Math.Min(a * 2, 2 * c);
            }
            else if (k == 3)
            {
                if (Math.Min(a * 3, b + a) > c)
                {
                    am += c;
                }
                else
                    am += Math.Min(a * 3, b + a);
            }
            Console.WriteLine(am);
            Console.ReadLine();
        }
    }
}