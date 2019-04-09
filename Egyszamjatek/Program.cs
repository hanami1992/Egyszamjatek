using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Egyszamjatek
{
    class Program
    {

        static List<Jatekos> jatekosok;
        static int sorszam;

        static void Main(string[] args)
        {
            F02();
            F03();
            F04();
            F05();

            Console.ReadKey();
        }

        private static void F05()
        {
            Console.Write("5. feladat: ");

            int sum = 0;
            foreach (var j in jatekosok)
            {
                sum += j.tippek[sorszam - 1];
            }
            Console.Write("A megadott forduló tippjeinek átlaga: {0:0.00}", (float)sum / jatekosok.Count);
        }

        private static void F04()
        {
            Console.Write("4. feladat: ");

            Console.Write("Kérem a forduló sorszámát: ");
            sorszam = int.Parse(Console.ReadLine());
        }

        private static void F03()
        {
            Console.Write("3. feladat: ");

            Console.WriteLine($"A játékosok száma: {jatekosok.Count} fő");
        }

        private static void F02()
        {
            jatekosok = new List<Jatekos>();

            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
