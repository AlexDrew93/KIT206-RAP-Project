using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{

    public class Student : Researcher
    {
   
        private string degree; 

        public string Degree
        {
            get
            {
                return givenname;
            }
            set
            {
                if (value != null)
                {
                    givenname = value;
                }
            }
        }

    }
}
