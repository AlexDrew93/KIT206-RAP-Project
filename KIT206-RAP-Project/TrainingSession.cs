using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    class TrainingSession
    {
        public enum EnumMode { Conference, Journal, Other };

        public string Title { get; set; }

        public int Year { get;  set; }

        public DateTime Certified { get;  set; }

        public EnumMode Mode { get;  set; }

        public override string ToString()
        {
            return Title + "completed by " + Mode + " on " + Certified.Date;
        }

        public int Freshness
        {
            get { return DateTime.Now.Subtract(Certified).Days; }
        }
    }
}
