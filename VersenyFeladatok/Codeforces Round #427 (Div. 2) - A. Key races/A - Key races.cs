using System;
using System.Collections.Generic;
using System.IO;

namespace Key_Races
{
    class Program
    {
        static int s, vEgy, vKetto, tEgy, tKetto, sumEgy, sumKetto;
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split();
            s = int.Parse(st[0]);
            vEgy = int.Parse(st[1]);
            vKetto = int.Parse(st[2]);
            tEgy = int.Parse(st[3]);
            tKetto = int.Parse(st[4]);

            sumEgy = tEgy * 2 + vEgy * s;
            sumKetto = tKetto * 2 + vKetto * s;
            Kiiras();
        }
        static void Kiiras()
        {
            if (sumEgy < sumKetto)
                Console.WriteLine("First");
            else if (sumEgy == sumKetto)
                Console.WriteLine("Friendship");
            else
                Console.WriteLine("Second");

            Console.ReadLine();
        }
    }
}