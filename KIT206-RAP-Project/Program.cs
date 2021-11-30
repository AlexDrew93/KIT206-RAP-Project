using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void PrintList(List<Employee> employees)
        {
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.ToString());

            }
        }

        static List<Employee> FilterByGender(List<Employee> staff, GenderEnum gender)
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