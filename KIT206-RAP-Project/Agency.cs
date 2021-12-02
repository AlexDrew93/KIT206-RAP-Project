using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name = "alex", Id = 1, Gender = Gender.M });
            employees.Add(new Employee { Name = "jane", Id = 2, Gender = Gender.F });
            employees.Add(new Employee { Name = "Celeste", Id = 3, Gender = Gender.X });
            employees.Add(new Employee { Name = "john", Id = 4, Gender = Gender.M });
            employees.Add(new Employee { Name = "Elizabeth", Id = 5, Gender = Gender.F });
            employees.Add(new Employee { Name = "Havoc", Id = 6, Gender = Gender.M });

            return employees;
        }
    }
}
