using System;
namespace Uppgift313
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen? Det måste vara i hela timmar.");
            int timmar = int.Parse(Console.ReadLine());
            int kr = (timmar * 80);

            if (kr <= 950)
            {
                Console.WriteLine(kr);
            }
            else
            {
                Console.WriteLine("Du har kört för länge.");
            }
        }
    }
}