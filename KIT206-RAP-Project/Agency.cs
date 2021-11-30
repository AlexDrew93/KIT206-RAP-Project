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

            employees.Add(new Employee { Name= "alex", Id = 1, gender = GenderEnum.M });
            employees.Add(new Employee { Name = "jane", Id = 2, gender = GenderEnum.F });
            employees.Add(new Employee { Name = "Celeste", Id = 3, gender = GenderEnum.X });
            employees.Add(new Employee { Name = "john", Id = 4, gender = GenderEnum.M });
            employees.Add(new Employee { Name = "Elizabeth", Id = 5, gender = GenderEnum.F });
            employees.Add(new Employee { Name = "Havoc", Id = 6, gender = GenderEnum.M });

            return employees;
        }
    }
}
