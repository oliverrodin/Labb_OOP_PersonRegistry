using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    
    
    public abstract class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        
        public string FullName => GetName();

        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName; 
        }

        /// <summary>
        /// Make a new Child when add one female and one male togethe
        /// </summary>
        /// <param name="f"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Person operator+ (Person f, Person m) =>
            new Child(f.FirstName, m.LastName);

        /// <summary>
        /// Abstract method that gets the name
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();

        /// <summary>
        /// Sort the list after last name and then after first name
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Person other) =>        
            LastName != other.LastName ? LastName.CompareTo(other.LastName) : FirstName.CompareTo(other.FirstName);
        

        


    }
}
