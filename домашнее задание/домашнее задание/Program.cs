using System;

namespace домашнее_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;



            Console.WriteLine("теорема Пифагора");
            Console.WriteLine("Если один из параметров неизвестен, то он, этот параметр, обозначается буквой");
            Console.WriteLine("Как правило эта буква Х");
            Console.WriteLine("введите значение катета А");
            bool a2 = double.TryParse(Console.ReadLine(), out a);
            if (a2 == false)
            {
                Console.WriteLine("введите значение катета B");
                bool b2 = double.TryParse(Console.ReadLine(), out b);
                if (b2 == false)
                {
                    Console.WriteLine("неверный ввод параметра одного из катетов");
                    Environment.Exit(0);
                }
                if (b < 0)
                {
                    Console.WriteLine("неверный ввод B");
                    Environment.Exit(0);

                }
                if (b == 0)
                {

                    Console.WriteLine("неверный ввод B");
                    Environment.Exit(0);

                }

                Console.WriteLine("введите значение гипотенузы C");

                bool c2 = double.TryParse(Console.ReadLine(), out c);
                if (c2 == false)
                {
                    Console.WriteLine("неверный ввод параметра катета А или параметра гипотенузы C");
                    Environment.Exit(0);
                }

                if (c < 0)
                {
                    Console.WriteLine("неверный ввод C");
                    Environment.Exit(0);

                }
                if (c == 0)
                {

                    Console.WriteLine("неверный ввод C");
                    Environment.Exit(0);
                }

                double R = Math.Pow(c, 2) - Math.Pow(b, 2);

                a = Math.Sqrt(R);
                Console.WriteLine("Ответ А = " + a);
                Environment.Exit(0);
            }
            if (a < 0)
            {
                Console.WriteLine("неверный ввод A");
                Environment.Exit(0);
            }

            if (a == 0)
            {

                Console.WriteLine("неверный ввод A");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("введите значение катета B");

                bool b2 = double.TryParse(Console.ReadLine(), out b);

                if (b2 == false)
                {
                    Console.WriteLine("введите значение гипотенузы C");

                    bool c2 = double.TryParse(Console.ReadLine(), out c);
                    if (c2 == false)
                    {
                        Console.WriteLine("неверный ввод пареметра гипотенузы C или параметра катета В");
                        Environment.Exit(0);
                    }

                    if (c < 0)
                    {
                        Console.WriteLine("неверный ввод C");
                        Environment.Exit(0);

                    }
                    if (c == 0)
                    {

                        Console.WriteLine("неверный ввод C");
                        Environment.Exit(0);
                    }

                    double P = Math.Pow(c, 2) - Math.Pow(a, 2);
                    b = Math.Sqrt(P);
                    Console.WriteLine("Ответ В = " + b);
                    Environment.Exit(0);
                }

                if (b < 0)
                {
                    Console.WriteLine("неверный ввод B");
                    Environment.Exit(0);

                }
                if (b == 0)
                {

                    Console.WriteLine("неверный ввод B");
                    Environment.Exit(0);
                }
                double S = Math.Pow(a, 2) + Math.Pow(b, 2);

                c = Math.Sqrt(S);
                Console.WriteLine("Ответ C = " + c);
                Environment.Exit(0);




            }
        }
    }
}
       
    


