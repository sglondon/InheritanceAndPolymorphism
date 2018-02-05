using System;

namespace InheritanceAndPoloymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parentOne = new Parent("bob");
            Child childOne = new Child(5);

            parentOne.ParentName();
            Console.WriteLine("The child's age is " + childOne.ChangeAge());

        }
    }
}
