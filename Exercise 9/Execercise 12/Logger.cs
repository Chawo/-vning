using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    class Logger : ILogger
    {
        //List property
        public List<string> LogPosts { get; set; }

        // default konstruktor
        public Logger()
        {
            LogPosts = new List<string>();
        }

        //metod 

        public void Log(string log)
        {
            LogPosts.Add(log);
        }

       

        
    }
}
