using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project.Research
{

    public class Student : Researcher
    {
   
        private string degree; 

        public string Degree
        {
            get
            {
                return degree;
            }
            set
            {
                if (value != null)
                {
                    degree = value;
                }
            }
        }

    }
}
