using System;


namespace EC2
{
    class Calculator
    {
        public int n1, n2;
        public Calculator(int a, int b)
        {
            n1 = a; n2 = b;
        }

        // overload the - operator
        public static Calculator operator -(Calculator c)
        {
            c.n1 = -c.n1;
            c.n2 = -c.n2;
            return c;
        }

        static void Main()
        {
            Calculator c1 = new Calculator(10, 20);
            Console.WriteLine("Before");
            Console.WriteLine($"N1: {c1.n1} and N2: {c1.n2}");
            c1 = -c1;
            Console.WriteLine("After");
            Console.WriteLine($"N1: {c1.n1} and N2: {c1.n2}");

            Console.ReadKey();
        }

    }
}
