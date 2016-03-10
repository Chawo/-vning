using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var logger = new Logger();
                var application = new LogApplication(logger);
                application.Run();
            }
                
                             
        }
    }
}
