using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaamasodik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]), a = int.Parse(s[1]), b = int.Parse(s[2]);
            int max = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Min(a / i, b / (n - i)) > max)
                {
                    max = Math.Min(a / i, b / (n - i));
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
