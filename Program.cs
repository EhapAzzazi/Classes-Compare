using System;

namespace ObjectsCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee();
            var emp2 = new Employee();
            ///////////////////////////
            emp1.ID = 1001;
            emp1.Name = "Ehap Azzazi";
            emp1.Salary = 3000m;
            emp1.Department = "Backend Dept.";
            //////////////////////////
            emp2.ID = 1001;
            emp2.Name = "Ehap Azzazi";
            emp2.Salary = 3000m;
            emp2.Department = "Backend Dept.";
            ///////////////////////////
            Console.WriteLine(emp1.Equals(emp2));
            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadKey();
        }
    }
}
