using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
   public class Family
    {
        //fields

        private string name;
        private int age;
        private string gender;
        private double height;

        //properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Family(string name)
        {
            this.name = name;
        }

        public Family(int age)
        {
            this.age = age;
        }


    }
}
