using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class EmployeeRegistry
    {
        public List<Employee> EmployeeList { get; set; }
         

        public EmployeeRegistry()
        {
            // The list needs to be initialized in order to be used
            EmployeeList = new List<Employee>();

         }



        // Registerar emoloyee
        public void RegisterEmployee(Employee employee)
        {
             EmployeeList.Add(employee);
            
           
        }


        //// Tar bort employee 
        public void RemoveEmployeeFromRegistry(Employee employee)
        {
            EmployeeList.Remove(employee);
        }



        // Visar hur många employee i registret
        public int NumberOfEmployeeInRegister
        {
            get { return EmployeeList.Count; }
        }




        public List<Employee> GetAllEmployee()
        {
            return EmployeeList;
        }

         


         


    }
}
