using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_12
{
    public interface ILogger
    {
        //List property
        List<string> LogPosts { get; set; }

        void Log(string log);

         



    }
}
