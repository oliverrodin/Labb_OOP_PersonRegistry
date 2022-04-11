using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    
    public class Female : Person
    {
        public Female()
        {

        }
        public Female(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Gender = "Miss.";
        }

        
        public override string GetName() => 
            $"{Gender}\t {FirstName} {LastName}"; 
    }
}
