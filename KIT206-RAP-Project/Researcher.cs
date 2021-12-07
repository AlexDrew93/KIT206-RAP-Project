using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project.Research
{
   

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
            return null;
        }

        public string CurrentJobTitle()
        {
            return null;
        }

        public DateTime CurrentJobStart()
        {
            return new DateTime(1943, 04, 01);
        }

        public Position GetEarliestJob()
        {
            return null;
        }

        public DateTime EarliestStart()
        {
            return new DateTime(1943, 04, 01);
        }

        public float Tenure()
        {
            return 0;
        }

        public int PublicationsCount()
        {
            return 0;
        }


    }
}
