using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i=0; i<num.Length; i++) 
            {
                num[i] = i;
                Console.Write("Vuvedi chislo: ");
                int n=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Chetni chisla sa: ");
                if (num[i]%2==0) 
                {
                    
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
