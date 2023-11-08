using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi neku validnu recenicu: ");
            string  recenica = Convert.ToString(Console.ReadLine());
            string [] rijeci = recenica.Split(' ');
            Console.WriteLine("Prva rijec u recenici je: " + rijeci[0]);
            Console.WriteLine("Zadnja rijec u recenici je: " + rijeci[rijeci.Length -1 ]);
            Console.ReadKey();
        }
    }
}
