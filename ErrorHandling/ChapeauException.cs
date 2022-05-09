using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class ChapeauException : Exception
    {
        public ChapeauException(string exMessage) : base(exMessage) { }
        public ChapeauException(string exMessage, Exception baseException) : base(exMessage, baseException) { }
    }
}
