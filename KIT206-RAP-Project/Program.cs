using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{
    public delegate Employee ManageWorker(int id);
  
    class Program
    {
        static void Main(string[] args)
        {
            //List<TrainingSession> certs = new List<TrainingSession>();

            //certs.Add(new TrainingSession { Title = "First Aid", Certified=new DateTime(2018,06,23), Year=2018, Mode=TrainingSession.EnumMode.Journal});
            //certs.Add(new TrainingSession { Title = "test2", Certified = new DateTime(2019, 11, 13), Year = 2019, Mode = TrainingSession.EnumMode.Other });
            //certs.Add(new TrainingSession { Title = "test3", Certified = new DateTime(2014, 05, 11), Year = 2014, Mode = TrainingSession.EnumMode.Conference });
            //certs.Add(new TrainingSession { Title = "test4", Certified = new DateTime(2012, 02, 21), Year = 2012, Mode = TrainingSession.EnumMode.Journal });
            //certs.Add(new TrainingSession { Title = "test5", Certified = new DateTime(2018, 01, 18), Year = 2018, Mode = TrainingSession.EnumMode.Other });

            //List<TrainingSession> fresh = filteredList(certs);
            //DisplayFreshCerts(fresh);

            Action doSomething;
            ManageWorker manage;

            Boss bigBoss = new Boss();

            doSomething = bigBoss.Display;
            manage = bigBoss.Fire;

            bigBoss.LoadSkills();
            doSomething();

            //List<TrainingSession> Test = Agency.LoadTrainingSessions(123466);
            //DisplayFreshCerts(Test);

            //Console.WriteLine("Dealing with {0}", manage(2));
            //doSomething();


            //bigBoss.Display();

            //Console.WriteLine("-----------------");

            //Employee tempStaff = bigBoss.Use(6);
            //Console.WriteLine(tempStaff.ToString());

            //Employee tempStaff2 = bigBoss.Fire(4);
            //Console.WriteLine(tempStaff2.ToString());

            //Console.WriteLine("-----------------");

            //bigBoss.Display();
        }

        static public List<TrainingSession> filteredList (List<TrainingSession> certs)
        {
            var filteredFresh = from f in certs
                                where f.Freshness <= 1000
                                select f;

            return new List<TrainingSession>(filteredFresh);
        }

        static public void DisplayFreshCerts(List<TrainingSession> fresh)
        {
            foreach (TrainingSession current in fresh)
            {
                Console.WriteLine(current.ToString());

            }
        }

        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            var filtered = from s in staff
                           where s.Gender == gender
                           select s;

            return new List<Employee>(filtered);
        }
    }
}
