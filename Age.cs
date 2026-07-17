using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC2
{
    class Age
    {
        int a;
        public Age(int aa)
        {
            a = aa;
        }
        void display()
        {
            Console.WriteLine("Age:" + a);
        }
        static void Main()
        {
            Age aaa = new Age(2);
            aaa.display();
            Console.ReadKey();

        }
    }
}
