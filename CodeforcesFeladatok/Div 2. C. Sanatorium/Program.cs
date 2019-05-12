using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div_2.C.Sanatorium
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long[] meals = new long[3];
            for (int i = 0; i < 3; i++)
            {
                meals[i] = long.Parse(s[i]);
            }
            //Egyenlők
            if (meals[0] == meals[1] && meals[1] == meals[2])
            {
                Console.WriteLine(0);
            }
            //d a legnagyobb
            else if (meals[1] > meals[0] && meals[1] > meals[2])
            {
                long ki = meals[1] - meals[0] + meals[1] - meals[2] - 4;
                if (ki < -1)
                {
                    ki += 2;
                }
                else if (ki == 0)
                {
                    ki += 3;
                }
                Console.WriteLine(ki);
            }
            //d és valamelik szélső egyenlők a másik pedig kissebb
            else if (meals[1] > Math.Min(meals[0], meals[2]) && meals[1] == Math.Max(meals[0], meals[2]))
            {
                long ki = (meals[1] - Math.Min(meals[0], meals[2])) * 2 -2;
                if (ki == 2)
                {
                    ki--;
                }
                Console.WriteLine(ki);
            }
            //valamelyik szélső a legnagyobb
            else if (meals[1] < Math.Max(meals[0], meals[2]))
            {
                long ki = Math.Max(meals[0], meals[2]) - Math.Min(meals[0], meals[2]) + Math.Max(meals[0], meals[2]) - meals[1] -2;
                if (meals[1] + 1 < Math.Min(meals[0], meals[2]))
                {
                    ki++;
                }
                else if (meals[0] == meals[2] && meals[1] < meals[2])
                {
                    ki++;
                }
                Console.WriteLine(ki);   
            }
            Console.ReadLine();
        }
        //for (int i = 0; i < 3; i++)
        //{
        //    meals[i] = long.Parse(s[i]); 
        //}
        //if (meals[2] > meals[1] && meals[2] > meals[0])
        //{
        //    Console.WriteLine(meals[2]- 1 - Math.Min(meals[0],meals[1]) );
        //}
        //else if (meals[0] > meals[1] && meals[0] > meals[2])
        //{
        //    Console.WriteLine(meals[0] - 1 - Math.Min(meals[2], meals[1]));
        //}
        //else if (meals[1] > meals[0] && meals[1] > meals[0] && meals[1] - meals[2] > 1 && meals[1] - meals[0] > 1)
        //{
        //    Console.WriteLine(meals[1] - 2 - Math.Min(meals[2], meals[0]));
        //}
        //else if (meals[1] > meals[0] && meals[1] > meals[0])
        //{
        //    Console.WriteLine(meals[1] - 1 - Math.Min(meals[2], meals[0]));
        //}
        //else
        //{
        //    Console.WriteLine();
        //}




        //string[] s = Console.ReadLine().Split();
        //    long[] meals = new long[3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        meals[i] = long.Parse(s[i]); 
        //    }
        //    Array.Sort(meals);
        //    if (meals[2] > meals[1] && meals[2] > meals[0])
        //    {
        //        long ki = meals[2]- 1 - meals[0] + meals[2]- 1 - meals[1]; 
        //        Console.WriteLine(ki);
        //    }
        //    else if (meals[0] > meals[1] && meals[0] > meals[2])
        //    {
        //        long ki = meals[0] - 1 - meals[2] + meals[0] - 1 - meals[1];
        //        Console.WriteLine(ki);
        //    }
        //    else if (meals[1] > meals[0] && meals[1] > meals[0] && meals[1] - meals[2] > 1 && meals[1] - meals[0] > 1)
        //    {
        //        long ki = meals[1] - 2 - meals[2] + meals[1] - 2 - meals[0];
        //        Console.WriteLine(ki);
        //    }
        //    else if (meals[1] > meals[0] && meals[1] > meals[0])
        //    {
        //        long ki = meals[1] - 1 - meals[2] + meals[1] - 1 - meals[0];
        //        if (meals[1] - meals[2] > 1 || meals[1] - meals[0] > 1)
        //            ki--;
        //        Console.WriteLine(ki);
        //    }
        //    else
        //    {
        //        Console.WriteLine(0);
        //    }
        //    Console.ReadLine();
    }
}
