using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //deklaration av variablar
            double total;
            int belopp;

            // try-cath

            //läs in värden
            Console.Write("Ange totalsumma:");
            total = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp:");
            belopp = int.Parse(Console.ReadLine());

            //Presentera Kvitto
            Console.WriteLine("KVITTO");
            
            

            
            
        }
    }
}
