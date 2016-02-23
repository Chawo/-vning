using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Logger
    {
        // default konstruktor
        public Logger()
        {
            LogPosts = new List<string>();
        }

        //metod

        public void Log(string information)
        {
            // med add så adderas all värde från string message i listan LogPosts
            LogPosts.Add(information);


            Console.Clear();
            Console.WriteLine("You've added something in your list");
            Console.WriteLine("Antal anställda : {0} \n", LogPosts.Count);
            Console.ReadKey();
        } 

        //List property
        public List<string> LogPosts { get; private set; }        // Show the list        //public void ShowTheList()
        //{
        //    Console.WriteLine("Here is the list of the Employee \n");
        //    foreach (var item in LogPosts)
        //    {
        //        Console.WriteLine(item);
        //        Console.WriteLine(" In the loop");

        //    }
        //    Console.WriteLine("Outside the loop");
        //}         
    }
}
