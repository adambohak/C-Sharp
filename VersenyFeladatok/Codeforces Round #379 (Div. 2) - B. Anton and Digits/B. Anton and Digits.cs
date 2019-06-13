using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_and_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int ketto = int.Parse(s[0]);
            int harom = int.Parse(s[1]);
            int ot = int.Parse(s[2]);
            int hat = int.Parse(s[3]);
            int min = Math.Min(ot, hat);
            if (min > ketto)
                min = ketto;
            int sum = 256 * min;
            ketto -= min;
            sum += Math.Min(ketto, harom) * 32;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}