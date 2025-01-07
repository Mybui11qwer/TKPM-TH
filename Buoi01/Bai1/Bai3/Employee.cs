using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    abstract class Employee
    {
        private string name;
        private double baseSalary;

        public abstract double CalculateSalary();

        public string Name { get; set; }
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public class Staff : Employee
        {
            public Staff(string name, double baseSalary)
            {
                this.name = name;
                this.baseSalary = baseSalary;
            }
            public override double CalculateSalary()
            {
                return baseSalary;
            }
        }

        public class Developer : Employee
        {
            private double OT;
            public Developer(string name, double baseSalary)
            {
                this.name = name;
                this.baseSalary = baseSalary;
            }
            public override double CalculateSalary()
            {
                return baseSalary;
            }
        }
        public void GetInfo()
        {
            Console.Write($"Lương của {name} là {baseSalary}");
        }
    }
}
