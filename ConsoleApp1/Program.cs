using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GeometryCalculator
    {
        static void Main(string[] args)
        {
            // Примеры использования библиотеки
            double circleRadius = 5;
            double circleArea = GeometryCalculator.CalculateCircleArea(circleRadius);
            Console.WriteLine($"Площадь круга с радиусом {circleRadius} равна {circleArea}");

            double triangleSide1 = 3;
            double triangleSide2 = 4;
            double triangleSide3 = 5;
            double triangleArea = GeometryCalculator.CalculateTriangleArea(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Площадь треугольника со сторонами {triangleSide1}, {triangleSide2}, {triangleSide3} равна {triangleArea}");

            bool isRightTriangle = GeometryCalculator.IsRightTriangle(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Треугольник со сторонами {triangleSide1}, {triangleSide2}, {triangleSide3} является прямоугольным: {isRightTriangle}");
            Console.ReadLine();
        }
        // Метод для вычисления площади круга по радиусу
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        // Метод для вычисления площади треугольника по трем сторонам
        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (!IsTriangleValid(side1, side2, side3))
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует.");
            }

            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        // Метод для проверки, является ли треугольник прямоугольным
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        // Метод для проверки существования треугольника по сторонам
        private static bool IsTriangleValid(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
    }
}
