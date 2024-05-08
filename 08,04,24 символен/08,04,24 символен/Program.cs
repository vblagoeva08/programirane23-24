using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_24_символен
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi ime: ");
            string str = "Hello, Viktoriq v C#";
            string name=Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.Write("Vuvedi prezime: ");
            string lastname=Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}" ,name , lastname);
            Console.Write("Vuvedi familiq: ");
            string family=Console.ReadLine();
            Console.WriteLine ($"Hi, {name} {lastname} {family} !!!");
            Console.ReadLine();
            int result=string.Compare(name,lastname,true);
            Console.WriteLine(result);
            Console.ReadLine() ;
            string str1=string.Concat(name,family);
            Console.WriteLine(str1);
            Console.ReadLine() ;
            string str2 = "Hello, Viktoriq to C#";
            Console.WriteLine(str2);
            Console.ReadLine() ;
            int firstIndex = str2.IndexOf(",");
            Console.WriteLine(firstIndex);
            Console.ReadLine() ;
            int secondIndex = str2.IndexOf("V",1);
            Console.WriteLine(secondIndex);
            Console.ReadLine() ;
            int notFound=str2.IndexOf("/");
            Console.WriteLine(notFound);
            Console.ReadLine() ;
            string str3 = "Hello, Viktoriq to C#";
            Console.WriteLine(str3);
            Console.ReadLine();
            string name1 = str3.Substring(7,8);
            Console.WriteLine(name1);
            Console.ReadLine();
            string Hello = str3.Substring(0, 5);
            Console.WriteLine(Hello);
            Console.ReadLine();
            string replace = str3.Replace("to C#","si otiva");
            Console.WriteLine(replace);
            Console.ReadLine();

        }
    }
}
