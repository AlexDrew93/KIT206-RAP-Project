using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    public delegate Employee ManageWorker(int id);
    
    class Program
    {
        static void Main(string[] args)
        {
            Action dosomething;
            ManageWorker manage;
             
            Boss bigBoss = new Boss();

            // bigBoss.Display();
            dosomething=bigBoss.Display;
            manage=bigBoss.Use;
            
            dosomething();
            Console.WriteLine("Dealing with {0}",manage(1));
            dosomething();
            
            
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
