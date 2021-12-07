using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project.Research
{
    public enum OutputType
    {
        
        Conference,
        Journal,
        Other
    }

    public class Publication
    {

        private string doi; 

        public string DOI
        {
            get
            {
                return doi;
            }
            set
            {
                if (value != null)
                {
                    doi = value;
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

       private string authors; 

       public string Authors
        {
            get
            {
                return authors;
            }
            set
            {
                if (value != null)
                {
                    authors = value;
                }
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value != null)
                {
                    date = value;
                }
            }
        }

        private OutputType type; 

        public OutputType Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value != null)
                {
                    type = value;
                }
            }
        }

        private string citeas; 

        public string CiteAs
        {
            get
            {
                return citeas;
            }
            set
            {
                if (value != null)
                {
                    citeas = value;
                }
            }
        }

        private DateTime availabledate; 

        public DateTime AvailableDate
        {
            get
            {
                return availabledate;
            }
            set
            {
                if (value != null)
                {
                    availabledate = value;
                }
            }
        }

        

        public int Age()
        {
            return 0;
        }


    }
}
