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
    }
}
