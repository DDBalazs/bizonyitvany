using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bizonyitvanyCli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neve: ");
            string neve = Console.ReadLine();

            Console.Write("Osztály: ");
            string osztaly = Console.ReadLine();

            Console.Write("Magyar: ");
            int magy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matek: ");
            int mat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Angol: ");
            int ang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Töri: ");
            int tor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Info: ");
            int info = Convert.ToInt32(Console.ReadLine());

            Console.Write("Igazolt hiányzás: ");
            int igazolt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Igazolatlan hiányzás: ");
            int igazolatlan = Convert.ToInt32(Console.ReadLine());

            Bizi b = new Bizi(neve,osztaly,magy, mat, ang, tor, igazolt, igazolatlan);
            Console.WriteLine("A tanuló átlaga: {0}",b.atlagszamitas());
            Console.WriteLine("A legjobb tantárgyai: {0}", b.legjobbosztalyzatVissza());
            Console.WriteLine(b.levelkuldes());
            Console.ReadKey();
        }
    }
}
