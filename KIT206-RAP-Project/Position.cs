using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project.Research
{
    public enum EmploymentLevel  
    {
        Student,
        A,
        B,
        C,
        D,
        E
    }

    public class Position
    {

        private DateTime startdate; 

        public DateTime StartDate
        {
            get
            {
                return startdate;
            }
            set
            {
                if (value != null)
                {
                    startdate = value;
                }
            }
        }

        private DateTime enddate; 

        public DateTime EndDate
        {
            get
            {
                return enddate;
            }
            set
            {
                if (value != null)
                {
                    enddate = value;
                }
            }
        }


        private EmploymentLevel level;

        public EmploymentLevel Level
        {
           get
           {
                return level;
           }
           set
           {
                if (value != null)
                {
                    level = value;
                }
           }
        }

       

        public string Title()
        {
            return null;
        }

        public string ToTitle(EmploymentLevel level)
        {
            return null;
        }

       


    }
}
