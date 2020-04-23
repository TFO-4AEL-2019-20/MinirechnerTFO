using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zahl1:");
            int  Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zahl2:");
         int  Zahl2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Ergebnis der Addition");
         Console.WriteLine(Addieren(Zahl1,Zahl2));

         Console.WriteLine("Ergebnis der Subtraktion");
         Console.WriteLine(Subtraktion(Zahl1, Zahl2));

         Console.WriteLine("Ergebnis der Multiplikation");
         Console.WriteLine(Multiplikation(Zahl1, Zahl2));
            Console.ReadKey();

        }
        static int Addieren(int Zahl1,int Zahl2)
        {
         return (Zahl1 +Zahl2);
          
        }
        static int Subtraktion(int Zahl1, int Zahl2)
        {
            return (Zahl1 - Zahl2);

        }

        static int Multiplikation(int Zahl1, int Zahl2)
        {
            return (Zahl1 * Zahl2);

        }



        }
    }

