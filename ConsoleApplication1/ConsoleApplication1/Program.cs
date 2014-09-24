using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //deklaration av variablar

            double total = 0;
            int belopp = 0;
            int tillbaka = 0;

            while (true)
            {

                try
                {
                    //läs in värden

                    Console.Write("Ange totalsumma      : ");
                    total = double.Parse(Console.ReadLine());
                    break;
                }

                //Fånga fel beroende på vad felet är
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Skriv in ett tal vid totalsumma och ett heltal vid erhållet belopp");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

            }

            //Avrundar total
            int avrundare = Convert.ToInt32(total);  //Math.Round

            while (true)
            {

                try
                {
                    Console.Write("Ange erhållet belopp : ");
                    belopp = int.Parse(Console.ReadLine());
                    
                    if (belopp < avrundare)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    break;
                }
                //Fånga fel beroende på vad felet är
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Erhållet belopp är mindre än totalsumman");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

            double oren = avrundare - total;

            //Beräkna
            tillbaka = belopp - avrundare;

            //Presentera
            Console.WriteLine(); //Blank rad
            Console.WriteLine("KVITTO");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(string.Format("Totalt                : {0,12:c}", total));
            Console.WriteLine(string.Format("Öresavrundning        : {0,12:c2}", oren));
            Console.WriteLine(string.Format("Att betala            : {0,12:c0}", avrundare));
            Console.WriteLine(string.Format("Kontant               : {0,12:c0}", belopp));
            Console.WriteLine(string.Format("Tillbaka              : {0,12:c0}", tillbaka));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(); //Blank rad

            //Lappar/kronor tillbaka
            int count = tillbaka / 500;            
            if (count > 0)
            {
                Console.WriteLine(string.Format("500-lappar            : {0,1}", count));
                tillbaka %= 500;
            }
            
            count = tillbaka / 100;
            if (count > 0)
            {
                Console.WriteLine(string.Format("100-lappar            : {0,1}", count));
                tillbaka %= 100;
            }
            
            count = tillbaka / 50;
            if (count > 0)
            {
                Console.WriteLine(string.Format("50-lappar             : {0,1}", count));
                tillbaka %= 50;
            }
            
            count = tillbaka / 20;
            if (count > 0)
            {
                Console.WriteLine(string.Format("20-lappar             : {0,1}", count));
                tillbaka %= 20;
            }
            
            count = tillbaka / 10;
            if (count > 0)
            {
                Console.WriteLine(string.Format("10-kronor             : {0,1}", count));
                tillbaka %= 10;
            }
            
            count = tillbaka / 5;
            if (count > 0)
            {
                Console.WriteLine(string.Format("5-kronor              : {0,1}", count));
                tillbaka %= 5;
            }

            count = tillbaka;
            if (count > 0)
            {
                Console.WriteLine(string.Format("1-kronor              : {0,1}", count));
            }
        }
    }
}
