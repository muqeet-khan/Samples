using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Engine.Core
{
    public class Person
    {
        public Guid Id { get; set; } = new Guid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Person> Dependents { get; set; }

        public Func<Person, string> FullName = p=> p.FirstName + " " + p.LastName?.ToString();

        public override string ToString()
        {
            return FullName(this);
        }

        public Person(string firstName,string lastName="")
        {
            FirstName = firstName;
        }

        public Person(Func<Person,string> fullName)
        {
            FullName = fullName;
        }

    }
}
