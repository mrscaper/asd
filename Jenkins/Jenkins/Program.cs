using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved");
            String nev = "";
            nev = Console.ReadLine();
            Console.WriteLine("{0} te kis homokos",nev);
            Console.ReadKey();
        }
    }
}
