using System;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Student.Product pro = new Student.Product("Laptop", 1000.0, 10);
            pro.SecretCode = "XYZ";
            if (pro.StockQuantity <= 0)
            {
                Console.Write("Stock Quantity phải lớn hơn 0");
            }
            else
            {
                pro.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}
