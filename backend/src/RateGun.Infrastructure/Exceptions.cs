using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{

    public class EmployeeListNotFoundException : Exception
    {
        public EmployeeListNotFoundException()
        {
        }

        public EmployeeListNotFoundException(string message)
            : base(message)
        {
        }

        public EmployeeListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}