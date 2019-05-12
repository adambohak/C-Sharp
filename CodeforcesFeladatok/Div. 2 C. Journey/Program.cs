using System;
using System.Collections.Generic;
using System.IO;

namespace Div._2_C.Journey
{
    class Program
    {
        static int n, m;
        static List<int>[] graf;
        static List<long>[] suly;
        static long T;
        struct Ut
        {
            public int erintett;
            public long hossz;
        }
        static void Main(string[] args)
        {
            Read();
            //Bellman-Ford
            List<Ut>[,] tabla = new List<Ut>[m-1, n+1];
            #region 1. oszlop
            for (int i = 1; i < n+1; i++)
            {
                tabla[0 ,i] = new List<Ut>();
                if (graf[i].IndexOf(1) != -1 && suly[i][graf[i].IndexOf(1)] < T)
                    tabla[0, i].Add(new Ut { hossz = suly[i][graf[i].IndexOf(1)], erintett = 1 });
            }
            #endregion
            for (int i = 1; i < m-1; i++)
            {
                for (int j = 1; j < n+1; j++)
                {
                    int csucs = j;
                    tabla[i, j] = new List<Ut>();
                    for (int k = 0; k < graf[csucs].Count; k++)
                    {
                        int szomszed = graf[csucs][k];
                        foreach (var item in tabla[i-1, szomszed])
                        {
                            if (item.hossz + suly[csucs][k] <= T)
                            {
                                tabla[i, j].Add(new Ut 
                                { 
                                    erintett = item.erintett + 1,
                                    hossz = item.hossz + suly[csucs][k]
                                });
                            }
                        }
                    }
                }
            }
            Ut ut = new Ut { hossz = 0, erintett = 0 };
            foreach (var item in tabla[m-2, n])
            {
                if (item.erintett > ut.erintett)
                {
                    ut = new Ut
                    {
                        erintett = item.erintett,
                        hossz = item.hossz
                    };
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Read()
        {
            StreamReader sr = new StreamReader("be.txt");
            string[] s = sr.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);
            T = long.Parse(s[2]);

            graf = new List<int>[n + 1];
            suly = new List<long>[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                graf[i] = new List<int>();
                suly[i] = new List<long>();
            }
            for (int i = 0; i < m; i++)
            {
                s = sr.ReadLine().Split(' ');
                graf[int.Parse(s[1])].Add(int.Parse(s[0]));
                suly[int.Parse(s[1])].Add(int.Parse(s[2]));
            }
            sr.Close();
        }
    }
}
