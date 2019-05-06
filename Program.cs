using System;
using System.Collections.Generic;
using System.IO;

namespace Épitkezés
{
    class Program
    {
        static SortedDictionary<int, HashSet<int>> munkak = new SortedDictionary<int, HashSet<int>>();
        static List<HashSet<int>> napok = new List<HashSet<int>>();
        static int munkakSzama, kapcsolatokSzama;
        static void Main(string[] args)
        {
            BeolvasKonzol();
            TopologikusRendezes();
            //Kiirás
            if (napok[napok.Count-1].Count == 0)
            {
                Console.Write(0);
            }
            else
            {
                Console.WriteLine(napok.Count);
                for (int i = 0; i < napok.Count; i++)
                {
                    foreach (var item in napok[i])
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void TopologikusRendezes()
        {
            do
            {
                napok.Add(new HashSet<int>());
                foreach (var item in munkak)
                {
                    if (item.Value.Count == 0)
                    {
                        napok[napok.Count - 1].Add(item.Key);
                    }
                }
                foreach (var item in napok[napok.Count-1])
                {
                    munkak.Remove(item);
                }
                foreach (var item in munkak)
                {
                    item.Value.ExceptWith(napok[napok.Count - 1]);
                }
            } while (munkak.Count > 0 && napok[napok.Count-1].Count > 0);
        }
        static void BeolvasKonzol()
        {
            string[] s = Console.ReadLine().Split(' ');
            munkakSzama = int.Parse(s[0]);
            kapcsolatokSzama = int.Parse(s[1]);
            for (int i = 1; i < munkakSzama + 1; i++)
            {
                munkak.Add(i, new HashSet<int>());
            }
            for (int i = 0; i < kapcsolatokSzama; i++)
            {
                s = Console.ReadLine().Split(' ');
                munkak[int.Parse(s[1])].Add(int.Parse(s[0]));
            }
        }
        static void BeolvasSzoveg()
        {
            StreamReader sr = new StreamReader("be.be");
            string[] s = sr.ReadLine().Split(' ');
            munkakSzama = int.Parse(s[0]);
            kapcsolatokSzama = int.Parse(s[1]);
            for (int i = 1; i < munkakSzama + 1; i++)
            {
                munkak.Add(i, new HashSet<int>());
            }
            for (int i = 0; i < kapcsolatokSzama; i++)
            {
                s = sr.ReadLine().Split(' ');
                munkak[int.Parse(s[1])].Add(int.Parse(s[0]));
            }
            sr.Close();
        }
    }
}
