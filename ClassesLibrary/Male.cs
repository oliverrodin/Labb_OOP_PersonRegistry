using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Male : Person
    {
        public Male()
        {

        }
        public Male(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Gender = "Mr.";
        }

        public override string GetName() => 
            $"{Gender}\t {FirstName} {LastName}";
    }
}
