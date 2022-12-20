using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor_IL_A21
{
    internal class A21Schüler
    {
        public string fach { get; set; }
        public double note { get; set; }

        public A21Schüler(string f,double no)
        {
            fach = f; note = no; 
        }
        public void NoteÄnderung()
        {
            try
            {
                Console.Write("\nGeben Sie die neue Note ein: ");
                double n = Convert.ToDouble(Console.ReadLine());
                if(n>=1.0 && n <= 6.0)
                {
                    note = n;
                }
                else
                {
                    Console.WriteLine($"\n{n} Note nicht möchlich (Falsche Eingabe)");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
