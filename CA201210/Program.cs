using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201210
{
    struct Osztaly
    {
        public int Evfolyam { get; set; }
        public char Betu { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Fakt(5));


            //Cseres01();
            //Console.WriteLine("\n----------------");
            //Cseres02();
            //Console.WriteLine("\n----------------");
            //Buborek();
            //Console.WriteLine("\n----------------");
            //Unio();
            //Console.WriteLine("\n----------------");
            //Metszet();
            //Console.WriteLine("\n----------------");
            //Osszefuttatas();




            Console.ReadKey(true);
        }

        private static void Cseres01()
        {
            //<, >, ==

            var t = new int[] { 20, 5, 11, 2, 6, 21, };

            for (int i = 0; i < t.Length - 1; i++)
            {
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[i] > t[j])
                    {
                        var s = t[i];
                        t[i] = t[j];
                        t[j] = s;
                    }
                }
            }

            foreach (var e in t)
            {
                Console.Write($"{e} ");
            }
        }
        private static void Cseres02()
        {
            var osztalyok = new List<Osztaly>()
            {
                new Osztaly() { Evfolyam = 11, Betu = 'A' },
                new Osztaly() { Evfolyam = 9, Betu = 'B' },
                new Osztaly() { Evfolyam = 13, Betu = 'E' },
                new Osztaly() { Evfolyam = 9, Betu = 'A' },
                new Osztaly() { Evfolyam = 10, Betu = 'B' },
            };

            for (int i = 0; i < osztalyok.Count - 1; i++)
            {
                for (int j = i + 1; j < osztalyok.Count; j++)
                {
                    if ((osztalyok[i].Evfolyam > osztalyok[j].Evfolyam)
                        || (osztalyok[i].Evfolyam == osztalyok[j].Evfolyam &&
                        osztalyok[i].Betu > osztalyok[j].Betu))
                    {
                        var s = osztalyok[i];
                        osztalyok[i] = osztalyok[j];
                        osztalyok[j] = s;
                    }
                }
            }

            Console.WriteLine();
            foreach (var o in osztalyok)
            {
                Console.Write($"{o.Evfolyam}.{o.Betu} ");
            }
        }
        private static void Buborek()
        {
            var tortek = new List<float>() { 12.4F, 66.65F, .004F, 105F, 42.00F };

            for (int i = tortek.Count; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (tortek[j] > tortek[j + 1])
                    {
                        var s = tortek[j];
                        tortek[j] = tortek[j + 1];
                        tortek[j + 1] = s;
                    }
                }
            }

            Console.WriteLine();
            foreach (var n in tortek)
            {
                Console.Write($"{n} ");
            }
        }
        private static void Osszefuttatas()
        {
            int[] a = { 2, 4, 5, 8, 10, 11 };
            int[] b = { 4, 8, 12, 21 };

            var ai = 0;
            var bi = 0;

            var ci = 0;
            var c = new int[a.Length + b.Length];

            while (ai < a.Length && bi < b.Length)
            {
                if (a[ai] < b[bi])
                {
                    c[ci] = a[ai];
                    ai++; ci++;
                }
                else if(a[ai] > b[bi])
                {
                    c[ci] = b[bi];
                    bi++; ci++;
                }
                else
                {
                    c[ci] = a[ai];
                    ai++; bi++; ci++;
                }
            }

            while (ai < a.Length)
            {
                c[ci] = a[ai];
                ci++; ai++;
            }

            while (bi < b.Length)
            {
                c[ci] = b[bi];
                ci++; bi++;
            }

            Array.Resize(ref c, ci);

            Console.Write("C:= { ");
            foreach (var e in c)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine("}");

        }
        private static void Metszet()
        {
            //metszet

            var a = new int[] { 1, 0, 3, 6, 9, 30, 34, 5, 21, 10 };
            var b = new int[] { 3, 5, 6, 40, 26, 21 };

            int ci = 0;
            var c = new int[(a.Length > b.Length) ? a.Length : b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                while (j < b.Length && a[i] != b[j]) j++;

                if (j < b.Length)
                {
                    c[ci] = a[i];
                    ci++;
                }
            }

            Console.Write("\nmetszet:= { ");
            for (int i = 0; i < ci; i++)
            {
                Console.Write($"{c[i]} ");
            }
            Console.WriteLine("}");
        }
        private static void Unio()
        {
            var a = new int[] { 1, 0, 3, 6, 9, 30, 34, 5, 21, 10 };
            var b = new int[] { 3, 5, 6, 40, 26, 21 };

            var ci = 0;
            var c = new int[a.Length + b.Length];

            for (; ci < a.Length; ci++) c[ci] = a[ci];

            //Console.WriteLine($"\n\ndb = {ci}");
            //Console.Write("C: = {");
            //for (int i = 0; i < ci; i++) Console.Write($"{c[i]} ");
            //Console.WriteLine("}");


            for (int j = 0; j < b.Length; j++)
            {
                int i = 0;
                while (i < a.Length && a[i] != b[j]) i++;
                if (i >= a.Length)
                {
                    c[ci] = b[j];
                    ci++;
                }
            }

            //Console.WriteLine($"\n\ndb = {ci}");
            Console.Write("C: = {");
            for (int i = 0; i < ci; i++)
            {
                Console.Write($"{c[i]} ");
            }
            Console.WriteLine("}");
        }


        public static int Fakt(int n)
        {
            if (n <= 0) throw new Exception("nem szám");
            if (n == 1) return 1;
            else return n * Fakt(n - 1);
        }
    }
}
