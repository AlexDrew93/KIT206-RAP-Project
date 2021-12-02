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
            Action doSomething;
            ManageWorker manage;

            Boss bigBoss = new Boss();

            doSomething = bigBoss.Display;
            manage = bigBoss.Fire;

            doSomething();
            Console.WriteLine("Dealing with {0}", manage(2));
            doSomething();


            //bigBoss.Display();

            //Console.WriteLine("-----------------");

            //Employee tempStaff = bigBoss.Use(6);
            //Console.WriteLine(tempStaff.ToString());

            //Employee tempStaff2 = bigBoss.Fire(4);
            //Console.WriteLine(tempStaff2.ToString());

            //Console.WriteLine("-----------------");

            //bigBoss.Display();
        }

        //static List<Employee> FilterByGender(List<Employee> staff, GenderEnum gender)
        //{
        //    List<Employee> newList = new List<Employee>();

        //    foreach (Employee currentEmployee in staff)
        //    {
        //        if (currentEmployee.gender == gender)
        //        {
        //            newList.Add(currentEmployee);
        //        }
        //    }

        //    return newList;
        //}
    }
}