using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._20_trifonzarezan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko imena shte vuvejdash: ");
            int n =int.Parse(Console.ReadLine());
            string[] vsime= new string[n];
            for (int i = 0; i < n; i++) 
            {
                Console.Write("Vevedi ime prezime i familiq: ");
                vsime[i] = Console.ReadLine();
                string[] ime= vsime[i].Split(' ');
                //string[] ime=Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine("izhod: ");
                Console.WriteLine(ime[i]);
                Console.WriteLine("ime[{0}]= {1}",i, ime[i] );
                Console.WriteLine("ime[{0}]={1}", i+1, ime[i+1] );
                Console.WriteLine("ime[{0}]={1}", i+2, ime[i+2]);
            }
            //izhod2 izvejdane na elementi ot posledniq do purviq
            for (int i = 0; i < n; i++)
            {
              
                Console.WriteLine("izhod 2 : ");
                string[] ime = vsime[i].Split(' ');
                Console.WriteLine("ime[{0}]= {1}", i + 2, ime[i + 2]);
                Console.WriteLine("ime[{0}]={1}", i + 1, ime[i + 1]);
                Console.WriteLine("ime[{0}]={1}", i , ime[i]);
            }
            // izhod 3
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("izhod 3 : ");
                string[] ime = vsime[i].Split(' ');
                Console.Write("{1} ", i , ime[i]);
                Console.WriteLine(" {1} ", i+2, ime[i+2]);

            }

        }
    }
}
