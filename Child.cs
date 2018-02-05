using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
    public class Child : Family
    {
        public Child(int age) : base(10)
        {

        }

        public int ChangeAge()
        {
            this.Age = ++Age;
            return Age;


        }
    }
}
