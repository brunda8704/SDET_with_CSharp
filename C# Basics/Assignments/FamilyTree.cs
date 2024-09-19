using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class FamilyTree
    {
        public FamilyTree()
        {
            Root = null;
        }

        public FamilyMember Root { get; set; }
        public void AddMember(FamilyMember parent,FamilyMember child)
        {
            parent.children.Add(child);
        }
        public void DisplayFamilyMember(FamilyMember member,string indent=" ")
        {
            Console.WriteLine($"{indent}Name:{member.Name}, Age:{member.Age}");
            
                foreach (var item in member.children)
                {
                    DisplayFamilyMember(item,indent + " ");
                }
           
        }


    }
}
