using System;
using System.Globalization;

namespace Icomparable.Entities
{
    internal class Employee : IComparable
    {
        public String Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) //Recebe o funcionario no formato csv
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1],CultureInfo.InvariantCulture);
        }

        public override string ToString() 
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee)) 
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
            
        }
    }
}
