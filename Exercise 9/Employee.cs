using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Employee
    {
        public string firstname;
        public string lastname;
        public int ssn;
        public string wage;
        
        public Employee()
        {

        } 

        //konstruktor maintask
        public Employee(string _firstName, string _lastName, int _ssn, string _wage)
        {
            firstname = _firstName;
            lastname = _lastName;
            ssn = _ssn;
            wage = _wage;

        } 
         
        public override string ToString()
        {
            return String.Format("Name: {0} {1} \nSSN: {2} \nWage: {3} \n_______________________", firstname, lastname, ssn, wage);
        }

        





    }
}
