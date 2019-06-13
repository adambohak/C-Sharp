using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div._2_A.Transformation_from_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long a = long.Parse(s[0]);
            long b = long.Parse(s[1]);
            List<long> list = new List<long>();

            while (b > a)
            {
                list.Add(b);

                if (b % 2 == 0)
                    b /= 2;
                else if (b > 10 && b % 10 == 1)
                    b /= 10;
                else
                    break;
            }
            if (a == b)
            {
                list.Add(b);
                Console.WriteLine("YES");
                Console.WriteLine(list.Count);
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.Write(list[i] + " ");
                }
            }
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}