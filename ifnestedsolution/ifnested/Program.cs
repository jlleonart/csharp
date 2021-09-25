using System;

namespace ifnested
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter an integer : ");
            var ans = Console.ReadLine();
            var nbr = Convert.ToInt32(ans);
            if (nbr % 2 == 0)
            { Console.WriteLine($"Number {nbr} is even"); }
            else
            { Console.WriteLine($"Number {nbr} is odd"); }
        }
    }
}
