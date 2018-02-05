using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
    public class Rectangle : Shape
    {
        //field
        private double area;

        //properties         has property that shape class has as well

        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }
        //derived class does not inherit the constructors
        //of the base class; however constructors of
        //the base class can be accessed using
        //the "base" keyword

        public Rectangle(double area) //tells to use sides 4 from  base class constructor : base(4)
        {
            this.area = area;
        }
    }


    
    }

