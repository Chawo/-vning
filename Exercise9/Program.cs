using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool flag = false;
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
                    string ssn = Console.ReadLine(); 

                    Console.Write("Wage:");
                    string wage = Console.ReadLine();


                    // skickar in värdet i objektet till klassen Employee där det sparas och lagras i en properties så
                    // det blir en enda string.
                    Employee employeeklass = new Employee(fname, lname, ssn, wage);
                    Logger loggerKlassen = new Logger();

                    // Här skickas all värde från information properties till Loggerlistan.
                    loggerKlassen.Log(employeeklass.Information);

                    var store = new EmployeeRegistry();
                    var AddingPadding = new Employee(fname, lname, ssn, wage);
                    store.AddCarToStore(AddingPadding);

                    ////Test ifall det finns något i listan som sparas.
                    //foreach (string item in loggerKlassen.LogPosts)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    //Console.WriteLine("\nCapacity: {0}", loggerKlassen.LogPosts.Count);

                }
                else if (choice == 2)
                {
                    
                    Console.Write("Remove a employee by writing hen ssn: ");
                    string removeEmployee = Console.ReadLine();
                }
                else if (choice == 3)
                {

                    

                }  
                else if (choice == 4)
                {
                    Console.WriteLine("You've chosen exit\n\nGoodbye...");

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


            //        // skickar in värdet i objektet
            //        Employee employeeklass = new Employee(fname, lname, ssn, wage);
            //        Logger loggerKlassen = new Logger();
            //        loggerKlassen.Log(fname, lname, ssn, wage);

            //        break;

            //    case 2:
            //        Console.Write("Remove a employee by writing hen ssn: ");
            //        string removeEmployee = Console.ReadLine();
            //        break;

            //    case 3:

            //        Logger loggerListan = new Logger();
            //        foreach (var item in loggerListan.LogPosts)
            //        {
            //            Console.WriteLine(item);
            //        }
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

