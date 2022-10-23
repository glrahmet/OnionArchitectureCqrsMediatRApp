using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public ValidationExceptions() : this("Validation error occured") { }

        public ValidationExceptions(string message) : base(message) { }

        public ValidationExceptions (Exception exception):this(exception.Message) { }
    }
}
