using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("ceo","judo",42,200),
                new Employee("Manager","joe",35,25),
                new Employee("pm","mary",32,21),
                new Employee("developer","rik",42,35),
                new Employee("artist","rikrik",42,30)
            };
            Dictionary<int, string> myDic = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two" },
                {3,"three" }
            };

            Dictionary<string, Employee> employeesDic = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeesDic.Add(emp.Role, emp);
            }
            string key = "ceo";
            if (employeesDic.ContainsKey(key))
            {
                Employee emp1 = employeesDic[key];
                Console.WriteLine("Employee name {0},role{1},salary{2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("no employee found with this key {0}", key);
            }
            
        }
    }
    class Employee
    {
        //few properties like role name age and rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        // yearly salary = rate/h * number of days * number of weeks* num of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        // simple constructor
        public Employee(string role,string name,int age,float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
