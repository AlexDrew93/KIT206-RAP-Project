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

        //Option 1 in tute, where the Employee object is queried to return the most recent publications count for them
        //LINQ can be altered for project to query how many publications for EACH year, rather than the total over the last year
        public int RecentTraining()
        {
            if (Skills != null)
            {
                int endYear = DateTime.Today.Year;
                int startYear = endYear - 1; //window is up to 2 years in length
                var allRecent = from TrainingSession skill in Skills
                                where skill.Year >= startYear && skill.Year <= endYear
                                select skill;
                return allRecent.Count();

            }
            return 0;
        }

        public override string ToString()
        { 
            string employee = (Name + ' ' + Id + ' ' + Gender + '\n' + "Total 'publications': " + RecentTraining() + '\n');
            string skills = "";

            foreach (TrainingSession current in Skills)
            {
                skills = skills + current.SkillsString() + '\n';

            }
            return  employee + skills;
        }

    }
}