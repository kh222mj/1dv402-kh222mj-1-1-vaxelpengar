﻿using System;
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
                double tillbaka = 0;
                int avrundare = 0;
                double oren = 0;
            
            while (true)
            {
                
                try
                {
                
                //läs in värden
                
                Console.Write("Ange totalsumma:");
                total = double.Parse(Console.ReadLine());

                Console.Write("Ange erhållet belopp:");
                belopp = int.Parse(Console.ReadLine());
                break;
                }
                
                catch
                {
                    Console.WriteLine("FEL");
                }

            }

                //Beräkna

                tillbaka = belopp - total;

                //Avrundar total
                avrundare = Convert.ToInt32(total);
                oren = total - avrundare;
                
                //Presentera

                Console.WriteLine(""); //Blank rad
                Console.WriteLine("KVITTO");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Totalt                : {0}", total);
                Console.WriteLine("Öresavrundning        : {0:f2}", oren);               
                Console.WriteLine("Att betala            : {0:f0}", total);
                Console.WriteLine("Kontant               : {0:f0}", belopp);
                Console.WriteLine("Tillbaka              : {0:f0}", tillbaka);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(""); //Blank rad

                //Lappar/kronor tillbaka

                Console.WriteLine("500-lappar            : " + (tillbaka - tillbaka % 500) / 500);
                tillbaka = tillbaka % 500;
                Console.WriteLine("100-lappar            : " + (tillbaka - tillbaka % 100) / 100);
                tillbaka = tillbaka % 100;
                Console.WriteLine("20-lappar             : " + (tillbaka - tillbaka % 20) / 20);
                tillbaka = tillbaka % 20;
                Console.WriteLine("5-kronor              : " + (tillbaka - tillbaka % 5) / 5);
                tillbaka = tillbaka % 5;
                tillbaka = tillbaka / 1;
                Console.WriteLine("1-kronor              : {0:f0}" ,tillbaka);
                

                


            
            
        }
    }
}