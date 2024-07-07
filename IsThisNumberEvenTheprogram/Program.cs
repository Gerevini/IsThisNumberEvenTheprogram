using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Program
    {
        static string Even(int number)
        {
            if (number % 2 == 0)
            {
                return "This number is even";
            }
            else
            {
                return "This number is odd";
            }
        }
        static void Main(string[] args)
        {
            int number = 3;
            Console.WriteLine(Even(number));

        }
    }
}

