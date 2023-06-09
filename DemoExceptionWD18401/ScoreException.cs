using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionWD18401
{
    internal class ScoreException : Exception
    {
        public ScoreException(string msg):
            base(msg)
        {
        }
    }
}
