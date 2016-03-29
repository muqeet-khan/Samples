using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Engine.Core
{
    public class Person
    {
        /// <summary>
        /// Represents the Persons's ID
        /// </summary>
        public Guid Id { get; set; } = new Guid();
        /// <summary>
        /// Gets or sets the person first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the person last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the person date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="List{Person}"/> as dependents 
        /// </summary>
        public List<Person> Dependents { get; set; }

        /// <summary>
        /// Returns the Fullname of the person
        /// </summary>
        private Func<Person, string> FullName = p => p.FirstName + " " + p.LastName?.ToString();
        
        /// <summary>
        /// Returns the full name of the person fullfilled by the function provided by fullname function <see cref="FullName"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //.....
            return FullName(this);
        }

        /// <summary>
        /// New instance of Person
        /// </summary>
        /// <param name="firstName">First name of the person</param>
        /// <param name="lastName">Last name of the person</param>
        public Person(string firstName,string lastName="")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// New instance of Person
        /// </summary>
        /// <param name="fullName"><inheritdoc cref="FullName"/></param>
        public Person(Func<Person,string> fullName)
        {
            FullName = fullName;
        }
    }
}
