using System;

namespace passwordchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "okay";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;
            string name = "";
            Console.Write("enter your name: ");
            name = Console.ReadLine();
            do
            {
                if (guesscount<guesslimit)
                {
                    Console.Write("enter your password: ");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguesses = true;
                }
            } while (guess != password && !outofguesses);
            if (outofguesses)
            {
                Console.WriteLine("your password is wrong! "+name);
            }
            else
            {
                Console.WriteLine("your password is correct! welcome " +name);
            }
            Console.ReadLine();
        }
    }
}
