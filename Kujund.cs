using System;

namespace Kujundid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a shape from the following: square, rectangle, triangle, circle");
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                Console.WriteLine("Enter the side lenght of the square:");
                string side = Console.ReadLine();
                int sqside = 0;
                try
                {
                    sqside = Int32.Parse(side);
                    int sqcircumf = 4 * sqside;
                    Console.WriteLine("Circumference of the square is '{sqcircumf}'");

                    int sqarea = sqside * sqside;
                    Console.WriteLine("Area of the square is '{sqarea}'");

                    for (int i = 1; i <= sqside; i++)
                    {
                        Console.WriteLine(
                            new string('*', sqside));
                    }
                }
                catch
                {
                    Console.WriteLine($"Something wrong with the input: '{side}'. Did you use numbers?");
                }
            }
            else if (shape == "circle")
            {
                {
                    {
                        double mittTal;
                        Console.Write("Circle radius: ");
                        mittTal = double.Parse(Console.ReadLine());

                        Console.WriteLine("Cirkumference of the circle is " + mittTal * mittTal * Math.PI);

                        Console.WriteLine("Area of the circle is " + mittTal * 2 * Math.PI);

                    }
                }
                for (var i = 1; i <= 10; i++)
                {
                    Console.WriteLine(new string('*', 10));

                }

            }
            else if (shape == "rectangle")
            {

                {
                    {
                        Console.WriteLine("Enter the length of the rectangle:");
                        double rectangleLength = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the width of rectangle:");
                        double rectangleWidth = Convert.ToDouble(Console.ReadLine());

                        double circumferenceOfRectangle = 2 * (rectangleLength) + 2 * (rectangleWidth);
                        Console.WriteLine("Circumference of the rectangle is: " + circumferenceOfRectangle);

                        double areaOfRectangle = rectangleLength * rectangleWidth;
                        Console.WriteLine("Area of the rectangle is: " + areaOfRectangle);
                    }
                }
                for (var i = 1; i <= 10; i++)
                {
                    Console.WriteLine(new string('*', 10));

                }

            }


            else if (shape == "triangle")
            {
                Console.WriteLine("Enter the side1 of the triangle:");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the side2 of the triangle:");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the side3 of the triangle:");
                double side3 = Convert.ToDouble(Console.ReadLine());

                double circumferenceOfTriangle = side1 + side2 + side3;
                Console.WriteLine("Circumference of the triangle is: " + circumferenceOfTriangle);

                double Area;
                double semiperimeter = (side1 + side2 + side3) / 2;
                Area = (int)Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

                Console.Write("Area of the triangle is : " + Area);
                Console.ReadLine();

                for (var row = 1; row <= side1; row++)
                {
                    Console.Write('*');
                    for (var col = 1; col < row; col++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
