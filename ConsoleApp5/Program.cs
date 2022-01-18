using System;

namespace ConsoleApp5
{
    public class Employee
    {
        public string Name;
        public int Age;

        public void  Greeting()
        {
            Console.WriteLine("Hi!My nameis " + Name +"and my age is " + Age);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee();
            Employee.Name = "Neela";
            Employee.Age = 21;

            Employee.Greeting();
        }
    }
}
