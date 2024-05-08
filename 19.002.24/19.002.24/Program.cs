using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._002._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            double[] nomer = new double[5];
            string[] ime = new string[5];
    
            //vhod
            for (int i=0; i< 5; i++) 
            {
                Console.WriteLine("Ime: ");
                ime[i]=Console.ReadLine();
                Console.WriteLine("Nomer: ");
               nomer[i]=double.Parse(Console.ReadLine());
            }
            //izhod
            for (int i=0; i<=5; i++)
            {
                Console.WriteLine(ime+ " " +nomer);
            }
            //izhod 2
            if (nomer.Length>3) 
            {
                Console.WriteLine(ime+ "  "+nomer);
            }
            //izhod 1=izhod 3
            Console.WriteLine("Kakvo ime shte tursq? ");
            string novoimme=Console.ReadLine();
            for (int i = 0; i <= 5; i++)
            {
                if (ime[i]==ime) 
                {
                    
                }
                Console.WriteLine(ime + " " + nomer);
              

            }
            
        }
    }
}
