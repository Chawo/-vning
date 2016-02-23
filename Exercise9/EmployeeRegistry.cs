using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class EmployeeRegistry
    {
        // I den här klassen så ska skapa lista för att skapa anställda 
        // & kunna ta bort anställda.

        private List<Employee> EmployeeRegister;

        public EmployeeRegistry()
        {
            // The list needs to be initialized in order to be used
            EmployeeRegister = new List<Employee>();
        }

        public void AddCarToStore(Employee employee)
        {
            EmployeeRegister.Add(employee);
            Console.WriteLine("You've add something in the list in the class EmployeeRegistry");
        }        public void RemoveCarFromStore(Employee employee)
        {
            EmployeeRegister.Remove(employee);
        }        public int NumberOfCarsInStore
        {
            get { return EmployeeRegister.Count; }
        }        public List<Employee> GetAllCars()
        {
            return EmployeeRegister;
        }


        ////default konstruktor.
        //public EmployeeRegistry()
        //{
        //    Anställda = new List<string>();
        //    var EmployeeInStore = new List<Employee>
        //    {

        //    };
        //}

        //public void AddToTheList (string information)
        //{
        //    Anställda.Add(information);
        //    Console.WriteLine("You are no in the AddToTheList metod in EmployeeRegistry");
        //}

        //public void ShowTheEmployeeList ()
        //{
        //    Console.WriteLine("You are now in metod ShowTheEmployeeList in class EmployeeRegistry");
        //    foreach (var item in Anställda)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //// Property lista
        //public List<string> Anställda { get; private set; }


    }
}
