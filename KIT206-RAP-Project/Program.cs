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
            Boss bigBoss = new Boss();

            bigBoss.Display();
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