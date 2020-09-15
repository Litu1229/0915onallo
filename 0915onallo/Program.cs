using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0915onallo
{
    class Teglalap
    {
        public int a;
        public int b;
        public int Kerulet()
        {
            return 2 * (a + b);
        }
        public int Terulet()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap o = new Teglalap();
            o.a = 10;
            o.b = 20;
            Console.WriteLine("A téglalap kerülete: {0}",o.Kerulet());
            Console.WriteLine("A téglalap területe: {0}", o.Terulet());
        }
    }
}
