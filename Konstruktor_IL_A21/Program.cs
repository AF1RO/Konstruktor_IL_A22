using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor_IL_A21
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Console.WriteLine  
            ("------------------------------------------------------------------------" +
           "\n|    Willkommen zu unserem Informatiker Noten Durchschnitt berechner   |" +
           "\n|----------------------------------------------------------------------|" +
           "\n| In diesem Program können Sie Ihre Noten einschreiben und abspeichern |" +
           "\n|                Drücken Sie *Enter*, um fortzufahren                  |" +
           "\n------------------------------------------------------------------------");
            Console.ReadLine();



            //Program
            there:
            int x = 0;
            GArray(ref x);
            Console.WriteLine();
            A21Schüler[] listeS = new A21Schüler[x];
            for(int i=0; i<listeS.Length; i++)
            {
                Console.Write("Fach: ");
                string fa = Console.ReadLine();
                Console.Write("\nNote: ");
                double no = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                A21Schüler a21 = new A21Schüler(fa, no);
                listeS[i] = a21;
                Console.Clear();
            }
            Console.WriteLine("Ihre Noten:");
            foreach (var c in listeS)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Fach:    {c.fach}\n" +
                                  $"Note:    {c.note}");
                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("\nMöchten Sie Ihre Module neu einschreiben? (j/n)");
            string choice = Console.ReadLine();
            if (choice == "j")
            {
                Console.Clear();
                goto there;
            }
            else
            {
                Console.WriteLine("\n\n\nMöchten Sie das Programm beenden? (j/n)");
                string choice2 = Console.ReadLine();
                if (choice2 == "j")
                {
                    Console.Clear();
                    Console.WriteLine("Schönen Tag!");
                }
                else
                {
                    Console.ReadKey();
                }
            }
        }
        static void GArray(ref int y)
        {
            Console.Write("Geben Sie an wie viele Module Sie haben: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}