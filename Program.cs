using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'Z' };
        
        static void Main(string[] args)
        {           
            string name;
            int age;
            Console.WriteLine("Hello World");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
            //string agestring = age.ToString();
            //char[] agechar = agestring.ToCharArray();
            //planerar här ett if sats som ser till att man inte matar in bokstäver
            Console.WriteLine("Your name is:" + name + " " + " Your age is: " + age);
            Console.ReadKey();
        }
    }
}
