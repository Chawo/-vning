﻿using System;
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
        }
        {
            this.ssn = _ssn;
        }
        {
            get { return firstname; }
            set { }
        }
        {
            get { return lastname; }
            set { }
        }
        {
            get { return ssn; }
            set { }
        }
        {
            get { return wage; }
            set { }
        }
        {
            get { return "Fullname: " + Firstname + " " + Lastname ; }
            set { }
        }
    }
}