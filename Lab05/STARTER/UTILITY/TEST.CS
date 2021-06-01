namespace Utils
{
    using System;

    public class Test
    {
        private static int x;
        static void Main()
        {
                int f;
            bool ok;

                Console.WriteLine("Number for factorial:");
                x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);
                if (ok)
                    Console.WriteLine("Factorial(" + x + ") = " + f);
                else
                    Console.WriteLine("Cannot compute this factorial");
            }
        }
    }

