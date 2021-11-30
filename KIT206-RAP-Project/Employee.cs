using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    enum GenderEnum
    {
        M,
        F,
        X
    }
    class Employee
    {


        private string name; 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != null)
                {
                    id = value;
                }
            }
        }


        public GenderEnum gender;
        public int Gender
        {
            get
            {
                return Gender;
            }
            set
            {
                if (value != null)
                {
                    Gender = value;
                }
            }
        }

        public override string ToString()
        {
            return name + " " + id + " " + gender;
        }


    }
}
