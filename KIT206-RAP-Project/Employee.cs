using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    public enum Gender { M, F, X };

    public class Employee
    {
        //Changed properties to auto-generated getters and setters for clarity
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender Gender { get; set; }

        public List<TrainingSession> Skills { get; set; }

        public override string ToString()
        {
            string employee = (Name + ' ' + Id + ' ' + Gender + '\n');
            string skills = "";

            foreach (TrainingSession current in Skills)
            {
                skills = skills + current.SkillsString() + '\n';

            }
            return  employee + skills;
        }

    }
}