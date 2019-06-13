using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_year_and_hurry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            k = 240 - k;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (k - i * 5 >= 0)
                {
                    sum++;
                    k -= i * 5;
                }
                else
                    break;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}