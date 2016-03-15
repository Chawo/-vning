using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    class DateTimeLogger : ILogger
    {
        public List<string> LogPosts
        {
            get; set;
        }

        public DateTimeLogger()
        {
            LogPosts = new List<string>();
        }

        public void Log(string log)
        {
            LogPosts.Add("Message: " + log + "\nDate: " + DateTime.Now);
        }

    }
}
