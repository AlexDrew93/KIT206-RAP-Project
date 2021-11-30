using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    public enum EmploymentLevel  // Put this with Position
    {
        Student,
        A,
        B,
        C,
        D,
        E
    }

    public class Researcher
    {

        private string givenname; 

        public string GivenName
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

       private string familyname; 

       public string FamilyName
        {
            get
            {
                return familyname;
            }
            set
            {
                if (value != null)
                {
                    familyname = value;
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

        private string title; 

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != null)
                {
                    title = value;
                }
            }
        }

        private string school; 

        public string School
        {
            get
            {
                return school;
            }
            set
            {
                if (value != null)
                {
                    school = value;
                }
            }
        }

        private string campus; 

        public string Campus
        {
            get
            {
                return campus;
            }
            set
            {
                if (value != null)
                {
                    campus = value;
                }
            }
        }

        private string email; 

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != null)
                {
                    email = value;
                }
            }
        }

        private string photoURL; 

        public string PhotoURL
        {
            get
            {
                return photoURL;
            }
            set
            {
                if (value != null)
                {
                    photoURL = value;
                }
            }
        }


       

        public Position GetCurrentJob()
        {
            ;
        }

        public string CurrentJobTitle()
        {
            ;
        }

        public DateTime CurrentJobStart()
        {
            ;
        }

        public Position GetEarliestJob()
        {
            ;
        }

        public DateTime EarliestStart()
        {
            ;
        }

        public float Tenure()
        {
            ;
        }

        public int PublicationsCount()
        {
            ;
        }


    }
}
