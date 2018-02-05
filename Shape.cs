using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
   public class Shape
    {
        //Fields
        private int sides;

        //Properties
        public int Side
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        //Constructors

        public Shape()
        {
            //default constructor
        }

        public Shape(int sides)
        {
            this.sides = sides;
        }

        //Methods
    }
}
