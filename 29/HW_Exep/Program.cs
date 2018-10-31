using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class.name);
            Console.WriteLine(Class.pi);
            PersonClass.Person person = new PersonClass.Person(17, "Олжас");
            Console.WriteLine(PersonClass.Person.PersonToString(person)); 
        }

     
    }
}
