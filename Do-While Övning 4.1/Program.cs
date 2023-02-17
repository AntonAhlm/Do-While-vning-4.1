using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många kvadrattal ska skrivas ut?");
            int Tal = Convert.ToInt32(Console.ReadLine());
            int Tal1 = 1;
            do
            {
                Console.WriteLine(Tal1+"*"+Tal1+"="+(Tal1*Tal1));
                Tal1++;
            } while (Tal1<=Tal);

        }
    }
}
