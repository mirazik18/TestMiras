using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class PersonalExceptions : Exception
    {
        public string EqualResultException { get; set; }
        
        public PersonalExceptions(string message) : base(message)
        {}
    }
}
