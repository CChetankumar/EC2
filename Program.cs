using System;
namespace EC2
{
    //Single Inheritance

    interface IEsubjects
    {
        void DSubject();
   
    }
    interface Isubjects
    {
        void DCSubject();
    }
    class Human
    {
        public void Greetings()
        {
            Console.WriteLine("Humans are use GPTS");
        }
    }
    class Person : Human
    {
        protected string name;
        protected int age;
        public void SetParameter(string n,int a)
        {
            name = n;
            age = a;
        }
    }
    class Student : Person , IEsubjects, Isubjects
    {
        int GRno;
        public void DSubject()
        {
            Console.WriteLine("DWDM");
            Console.WriteLine("CCE");
        }
        public void DCSubject()
        {
            Console.WriteLine("FM");
            Console.WriteLine(".NET");
        }
        public void SetGrno(int g)
        {
            GRno = g;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gr No: " + GRno);
        }
        static void Main()
        {
            Student s1 = new Student();
            s1.SetGrno(12345);
            s1.SetParameter("Vishnu", 19);
            s1.Display();
            s1.Greetings();
            s1.DSubject();
            s1.DCSubject();
            Console.ReadKey();
        }
        
    }
    
}
