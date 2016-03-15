using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Logger
    {
        //List property
        public List<string> LogPosts { get; private set; }
        
        // default konstruktor
        public Logger()
        {
            LogPosts = new List<string>();
        }

        //metod

        public void Log(string information)
        {
           
            // med add så adderas all värde från string message i listan LogPosts
            LogPosts.Add(information + "\n" + DateTime.Now);
             
         } 
         
         
    }
}
