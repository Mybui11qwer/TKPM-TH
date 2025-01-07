using System;
using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Shape.Circle circle = new Shape.Circle(30);
            Console.WriteLine($"Chu vi của hình tròn có bán kính {circle.Radius} là: " + circle.CalculatePerimeter());
            Console.WriteLine($"Diện tích của hình tròn có bán kính {circle.Radius} là: " + circle.CalculateArea());

            Shape.Rectangle rectangle = new Shape.Rectangle(10, 20);
            Console.WriteLine($"Chu vi của hình chữ nhật có kích thức ({rectangle.Width}x{rectangle.Lenght}) là: " + rectangle.CalculatePerimeter());
            Console.WriteLine($"Diện tích của hình chữ nhật có kích thức ({rectangle.Width}x{rectangle.Lenght}) là: " + rectangle.CalculateArea());
        }
    }
}
