using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class Student
    {
        public class Product
        {
            private double costPrice;
            private string secretCode;
            private int stockQuantity;
            
            public string Name { get; private set; }
            
            public double CostPrice
            {
                get { return costPrice; }
            }
            public string SecretCode
            {
                set { secretCode = value; }
            }
            public int StockQuantity
            {
                get { return stockQuantity; }
                set
                {
                    if(value > 0)
                    {
                        stockQuantity = value;
                    }
                    if(value <= 0)
                    {
                        Console.WriteLine("StockQuantity phai lon hon 0");
                    }
                }
            }
            public double SellingPrice
            {
                get { return costPrice * 1.5; }
            }
            public Product()
            {
                //Not thing
            }
            public Product(string name, double CostPrice, int StockQuantity)
            {
                this.Name = name;
                this.costPrice = CostPrice;
                this.stockQuantity = StockQuantity;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Product Name: {Name}");
                Console.WriteLine($"Cost Price: {CostPrice}");
                Console.WriteLine($"Stock Quantity: {StockQuantity}");
                Console.WriteLine($"Selling Price: {SellingPrice}");
            }
        }
    }
}
