using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    public class TrainingSession
    {
        public enum EnumMode { Conference, Journal, Other };

        public string Title { get; set; }

        public int Year { get;  set; }

        public DateTime Certified { get;  set; }

        public EnumMode Mode { get;  set; }

        public string SkillsString()
        {
            return Title + " completed by " + Mode + " on " + Certified.Day + '/' + Certified.Month + '/' + Certified.Year;
        }

        public int Freshness
        {
            get { return DateTime.Now.Subtract(Certified).Days; }
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
