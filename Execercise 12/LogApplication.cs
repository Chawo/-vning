using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    class LogApplication
    {
        ILogger Ilogger;
        static Logger LoggerClass = new Logger();

        public LogApplication(ILogger _Ilogger)
        {
            Ilogger = _Ilogger;
        }

        public void Run()
        {

            Console.Write("\n1) Add message to log \n2) Print Log \n\nChoice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            { 
                Console.Write("Write a message: ");
                string message = Console.ReadLine();
                LoggerClass.Log("\n" + message + "\nDate: " + DateTime.Today + "\n_____________________________");
            }
            else if (choice == 2)
            {
                foreach (var message in LoggerClass.LogPosts)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
