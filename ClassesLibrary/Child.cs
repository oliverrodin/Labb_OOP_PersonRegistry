using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Child : Person
    {
        public Child()
        {

        }
        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
            Gender = "Child.";
        }
       
        public override string GetName() => 
            $"{Gender}\t {FirstName} {LastName}";
    }
}
