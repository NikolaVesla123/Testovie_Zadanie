using System;

namespace Testovoe_2
{
    static class Square
    {
        public static double areaSquare(double r)
        {
            double square;

            square = Math.PI * Math.Pow(r, 2);

            return square;
        }


        public static double triangleSquare(double a, double b, double c)
        {
            double P, square;

            P = (a + b + c) / 2;
            square = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            return square;
        }


        public static double ballVolume(double p)
        {
            double volume;

            volume = (4 * Math.PI * Math.Pow(p, 3)) / 3;

            return volume;
        }

        public static bool createTriangle(double a, double b, double c)
        {
            if (c < b + a)
            {
                if ((b < c + a))
                {
                    if ((a < b + c))
                        return true;

                    else return false;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            double input, a, b, c;

            Console.WriteLine("Площадь круга");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Square.areaSquare(input));

            Console.WriteLine("Площадь треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Square.triangleSquare(a, b, c));

            Console.WriteLine("Объем шара");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Square.ballVolume(input));

            Console.WriteLine("Проверка возможности построения треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Square.createTriangle(a, b, c));

            Console.ReadLine();
        }
    }
}
