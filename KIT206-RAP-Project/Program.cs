using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> e = GenerateData();

            PrintList(e);

            Console.ReadLine();

            PrintList(FilterByGender(e, Gender.X));

            Console.ReadLine();

            PrintList(FilterByGender(e, Gender.F));

            Console.ReadLine();

            PrintList(FilterByGender(e, Gender.M));

        }

        static List<Employee> GenerateData()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { name = "alex", id = 1, gender = Gender.M });
            employees.Add(new Employee { name = "jane", id = 2, gender = Gender.F });
            employees.Add(new Employee { name = "Celeste", id = 3, gender = Gender.X });
            employees.Add(new Employee { name = "john", id = 4, gender = Gender.M });
            employees.Add(new Employee { name = "Elizabeth", id = 5, gender = Gender.F });
            employees.Add(new Employee { name = "Havoc", id = 6, gender = Gender.M });

            return employees;
        }

        static void PrintList(List<Employee> employees)
        {
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.ToString());

            }
        }

        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> newList = new List<Employee>();

            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.gender == gender)
                {
                    newList.Add(currentEmployee);
                }
            }

            return newList;
        }
    }
}