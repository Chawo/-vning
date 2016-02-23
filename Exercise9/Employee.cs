using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Employee
    {

        //string firstname = "Katrina";
        //string lastname = "Rosales";
        //string ssn = "101010-5546";
        //string wage = "Vet ej vad detta är ?";

        private string _firstname;
        private string _lastname;
        private string _ssn;
        private string _wage;


        //default konstruktor
        public Employee ()
        {

        }

        //konstruktor maintask
        public Employee(string firstName, string lastName, string ssn, string wage)
        {
            this._firstname = firstName;
            this._lastname = lastName;
            this._ssn = ssn;
            this._wage = wage;

        }        // konstruktor stretchtask        public Employee(string ssn)
        {
            this._ssn = ssn;
        }        // Properties        public string Firstname
        {
            get { return _firstname; }
            set { }
        }        public string Lastname
        {
            get { return _lastname; }
            set { }
        }        public string SSN
        {
            get { return _ssn; }
            set { }
        }        public string Wage
        {
            get { return _wage; }
            set { }
        }        // Med denna koden så skickas både, Firstname, Lastname, SSN & Wage i en enda string till listan.        public string Information
        {
            get { return "Information \n----------------------------\nName: " + Firstname + " " + Lastname + "\nSSN: " + SSN + "\nWage: " + Wage; }
            set { }
        }
    }
}
