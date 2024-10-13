using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        { //case 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); //  I den första if-satsen det saknades ett semikolon 
            }
            else if (number < 3)  // Else if saknade mellanrum och skrevs ihop som elseif, som var inte rätt
            {
                Console.WriteLine("Talet är mindre än tre");
            }
            //case 2
            for (int i = 1; i <= 100; i++)// Här borde man ha mer än bara < tecken
            {
                Console.WriteLine(i);
            }
            //case 3
            for (int i = 1; i <= 5; i++)// ++ som inkrementering för i, saknades en "action to perform"
            {
                for (int j = 1; j <= i; j++)// ++ som inkrementering för j, saknades en "action to perform"
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //case 4
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // Adderade variabeln j i Console.Write, så att användaren kan se att for-loopen räknar korrekt
                }

                Console.WriteLine($"\n den ska köras {i} gånger");//  Fick ingen output eftersom både Console.Write och Console.WriteLine var tomma
                i++;
            }

            // case 5
            int i = 1;

            switch (i)
            {
                case 1:
                    Console.WriteLine("One");// La till Console.WriteLine
                    break; //Adderade ett break i case 1, annars caset visar sig att den är tomt och programmet hoppar till nästa case tills det hittar ett break 
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            // case 6
            int i = 10;

            if (i == 5) // la  == som är "lika med" eftersom  der är en logisk jämförelseoperator som returnerar antingen true eller false
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}
