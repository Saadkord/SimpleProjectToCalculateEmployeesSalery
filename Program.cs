using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Oop_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Employee> employees = new List<Employee>
            {
                new Managers
                      { Id = 01,  FName = "Saad",  LName = "A.",  LogedHoure = 40 },

                new SalesAgent
                      { Id = 02,  FName = "Ali",  LName = "H.",  LogedHoure = 50 },

                new Handyman
                      { Id = 03,  FName = "Hany",  LName = "W.",  LogedHoure = 55 },

                new Handyman
                      { Id = 04,  FName = "Weal",  LName = "K.",  LogedHoure = 55 },
            };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.print());
            }

            Console.ReadKey();
        }
    }
}