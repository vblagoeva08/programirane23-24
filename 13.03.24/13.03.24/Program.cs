using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++) 
            {

            }
            for (int i = 0; i < arr.Length; i++) 
            {
                int swapVar = arr[i];
                int index = i;
                while(index>0 && arr[index - 1] >= swapVar) 
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
