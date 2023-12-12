
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Oriflame
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("Зубенко Михаил Петрович", 1, 20000),
                new Employee("Зубенко Михаил Петрович", 1, 20000),
                new Employee("Зубенко Михаил Петрович", 1, 20000),
                new Employee("Зубенко Михаил Петрович", 1, 20000),
                new Employee("Зубенко Михаил Петрович", 1, 20000)
            };

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine((i + 1) + " ");

                employees[i].ShowEmployee();
            }
        }
    }

      class Employee
    {
        private int Id;
        private string Name;
        private int Salary;

        public Employee(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Сотрудник = {Name}, Id = {Id}, зарплата = {Salary}");
        }

    }
    

   
}