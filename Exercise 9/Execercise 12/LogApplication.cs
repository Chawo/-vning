using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    class LogApplication 
    {
        ILogger _myIlogger;
         
        public LogApplication(ILogger myIlogger)
        {
            this._myIlogger = myIlogger;
        } 

        public void Run ()
        {
            while (true)
            {
                Console.WriteLine("1) Add message to log \n2) Print log \n\nChoice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Write a message here: ");
                    string log = Console.ReadLine();
                    _myIlogger.Log(log);
                }
                if (choice == 2)
                {
                    foreach (var item in _myIlogger.LogPosts)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            
        }

         



    }
}
