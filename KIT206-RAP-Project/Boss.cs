using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    class Boss
    {
        private List<Employee> staff;

        public Boss() {
            staff = Agency.Generate();
        }

        public void Display()
        {
            foreach (Employee currentEmployee in staff)
            {
                Console.WriteLine(currentEmployee.ToString());

            }
        }

        public Employee Use(int id) {
            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.Id == id)
                {
                    return currentEmployee;
                }
            }

            return null;
        }

        public Employee Fire(int id)
        {
            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.Id == id)
                {
                    staff.Remove(currentEmployee);
                    return currentEmployee;
                }
            }
            return null;
        }
    }
}
