using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string Secretcode;
            Console.Write("input 3 capital letters : ");
            Secretcode = Console.ReadLine();
            int number, one, ten, hundred, thousand, tenthousand, onehundredthousand;
            Console.Write("Password : ");
            number = int.Parse(Console.ReadLine());

            one = number % 10;
            ten = (number % 100) / 10;
            hundred = (number % 1000) / 100;
            thousand = (number % 10000) / 1000;
            tenthousand = (number % 100000) / 10000;
            onehundredthousand = (number % 1000000) / 100000;
            bool A;
            if (Secretcode == "CIA" )
            {
                A = (one % 3 == 0 && ten != (1 & 3 & 5) && thousand >= 6 && thousand != 8);
                Console.WriteLine("{0}", A);
            }
            if (Secretcode == "FBI" )
            {
                A = (onehundredthousand >= 4 && onehundredthousand <= 7 && hundred % 2 == 0 && hundred != 6 && hundred % 2 != 0);
                Console.WriteLine("{0}", A);
            }
            if (Secretcode == "NSA" )
            {
                A = (30 % one == 0 && hundred % 3 == 0 && hundred % 2 != 0 && (one == 7 || ten == 7 || hundred == 7 || thousand == 7 || tenthousand == 7 || onehundredthousand == 7));
                Console.WriteLine("{0}", A);
            }
            else
            {
                A = false;
                Console.WriteLine("{0}",A);
            }
        }
    }
}

