using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_9
{
    class Employee
    {

        string firstname;
        string lastname;
        string ssn;
        string wage;


        //konstruktor maintask
        public Employee(string _firstName, string _lastName, string _ssn, string _wage)
        {
            firstname = _firstName;
            lastname = _lastName;
            ssn = _ssn;
            wage = _wage;
        }        // konstruktor stretchtask        public Employee(string _ssn)
        {
            this.ssn = _ssn;
        }        // Properties        public string Firstname
        {
            get { return firstname; }
            set { }
        }        public string Lastname
        {
            get { return lastname; }
            set { }
        }        public string SSN
        {
            get { return ssn; }
            set { }
        }        public string Wage
        {
            get { return wage; }
            set { }
        }        // Stretch task        public string Fullname
        {
            get { return "Fullname: " + Firstname + " " + Lastname ; }
            set { }
        }
    }
}
