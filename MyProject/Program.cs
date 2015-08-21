using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        // Функция вычисления площади прямоугольного треугольника по двум катетам
        public static double AreaRightTriangle(double cathetusA, double cathetusB)
        {
            if (cathetusA <= 0.0 || cathetusB <= 0.0) return 0.0; // треугольник не существует
            return cathetusA * cathetusB / 2.0;
        }

        // Функция вычисления площади прямоугольного треугольника по трем сторонам
        public static double AreaRightTriangle(double a, double b, double c)
        {
            if (a <= 0.0 || b <= 0.0 || c <= 0.0 || a + b < c || a + c < b || b + c < a)
                return 0.0; // треугольник не существует
            if (a > b)
            {
                if (a > c && b * b + c * c == a * a) return b * c / 2.0;
                else if (a * a + b * b == c * c) return a * b / 2.0;
                else return 0.0; // треугольник не прямоугольный
            }
            else
            {
                if (b > c && a * a + c * c == b * b) return a * c / 2.0;
                else if (a * a + b * b == c * c) return a * b / 2.0;
                else return 0.0; // треугольник не прямоугольный
            }
        }

        // Функция вычисления площади любого треугольника по трем сторонам
        public static double AreaTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return 0.0; // треугольник не существует
            double p = (a + b + c) / 2.0;
            double s = p * (p - a) * (p - b) * (p - c);
            if (s > 0.0) return Math.Sqrt(s);
            else return 0.0; // треугольник не существует
        }
    }
}