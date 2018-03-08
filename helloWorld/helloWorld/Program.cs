using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            f1();
            f2();
        }

        public static void f1()
        {
            Console.WriteLine("Soc la funció1, soc en Xevi.");
            Console.WriteLine("Soc la funció1, soc en Xevi i torno a manipular.");
        }

        public static void f2()
        {
            Console.WriteLine("Soc la funció2");
        }
    }
}
