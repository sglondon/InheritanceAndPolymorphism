using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
    public class Parent : Family
    {


        public Parent(string name) //: base("John")
        {
            this.Name = name;
            
        }

        public void ParentName()
        {
            Console.WriteLine("The parent's name is " + this.Name);
        }
    }
}

