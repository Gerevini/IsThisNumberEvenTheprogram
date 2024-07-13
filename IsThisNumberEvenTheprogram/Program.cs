
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

