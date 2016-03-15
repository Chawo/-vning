using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static EmployeeRegistry kalle = new EmployeeRegistry();
        static Logger log = new Logger();

        static void Main(string[] args)
        {
            

            //bool flag = false;
            while (true)
            {
                Console.Write("1. Add Employee \n2. Remove Employee \n3. Print entire registry \n4. Exit \n\nEnter choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                 
                if (choice == 1)
                {
                    Console.WriteLine("Add a new employee\n\n-----------------\n");
                    Console.Write("Firstname:");
                    string fname = Console.ReadLine();

                    Console.Write("Lastname:");
                    string lname = Console.ReadLine();

                    Console.Write("SSN:");
                    int ssn = int.Parse(Console.ReadLine());

                    Console.Write("Wage:");
                    string wage = Console.ReadLine();

                    var newEmp = new Employee(fname, lname, ssn, wage);
                    kalle.RegisterEmployee(newEmp);
                    log.Log("You've added a new employee\n");
 


                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n\nWrite his/her SSN");
                    int remove = int.Parse(Console.ReadLine());

                    Employee employee = null; 
                    foreach (var item  in kalle.EmployeeList)
                    {
                        if (item.ssn == remove)
                        {
                            employee = item;
                        }
                    }
                    kalle.RemoveEmployeeFromRegistry(employee);
                    log.Log("You've removed an employee");


                }
                else if (choice == 3)
                {
                    foreach (var item in kalle.GetAllEmployee())
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("log");
                    foreach (var item in log.LogPosts)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (choice == 4)
                {
                    Console.WriteLine("You've chosen exit\n\nGoodbye.....");

                }
                else
                {
                    Console.WriteLine("You didn't choose any of the following options!");
                }
            }


            //switch (choice)
            //{
            //    case 1:
            //        Console.Clear();
            //        Console.WriteLine("Add a new employee\n\n-----------------\n");
            //        Console.Write("Firstname:");
            //        string fname = Console.ReadLine();

            //        Console.Write("Lastname:");
            //        string lname = Console.ReadLine();

            //        Console.Write("SSN:");
            //        string ssn = Console.ReadLine();

            //        Console.Write("Wage:");
            //        string wage = Console.ReadLine();


            //        var newEmp = new Employee(fname, lname, ssn, wage);
            //        EmployeeRegistry kalle = new EmployeeRegistry();
            //        kalle.RegisterEmployee(newEmp);

            //        break;

            //    case 2:
            //        Console.Write("Remove a employee by writing hen ssn: ");
            //        string removeEmployee = Console.ReadLine();
            //        break;

            //    case 3:

            //        var Print = new EmployeeRegistry();
            //        Print.GetAllEmployee();
            //        break;

            //    case 4:
            //        Console.WriteLine("You've chosen exit\nGoodbye");
            //        break;
            //    default:
            //        break;
            //}







        }

    }
    }

