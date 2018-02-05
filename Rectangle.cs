using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPoloymorphismPractice
{
    public class Rectangle : Shape
    {
        private double area;

        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        public Rectangle(double area)
        {
            this.area = area;
        }
    }


    
    }

