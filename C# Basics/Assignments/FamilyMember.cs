using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class FamilyMember
    {
        public FamilyMember(string? name, int age)
        {
            Name = name;
            Age = age;
            children= new List<FamilyMember>();
        }

        public string? Name { get; set; }    
        public int Age { get; set; }
        public List<FamilyMember> children { get; set;}

       
        



    }
}
