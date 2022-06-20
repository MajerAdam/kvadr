using System;

namespace KvadrFunkce
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                string x1 = "";
                string x2 = "";
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());

                if (a != 0)
                {
                    Console.Write("b = ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c = ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double d = Counting.Discriminant(a, b, c);
                    if (d >= 0)
                    {
                        x1 = $"{Counting.AnswerDbigernullX1(d, a, b)}";
                        x2 = $"{Counting.AnswerDbigernullX2(d, a, b)}";
                    }
                    else
                    {
                        x1 = Counting.AnswerDSmallernullResoltX1(d, a, b);
                        x2 = Counting.AnswerDSmallernullResoltX2(d, a, b);
                    }

                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");

                }
                else
                {
                    Console.WriteLine("pokud se A = 0, není kvadratická rovnice");
                }
            }
            

        }
    }
}
