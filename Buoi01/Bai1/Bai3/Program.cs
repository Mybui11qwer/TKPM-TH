using System;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Employee.Staff employee = new Employee.Staff("Nam", 10);
            employee.GetInfo();
        }
    }
}
