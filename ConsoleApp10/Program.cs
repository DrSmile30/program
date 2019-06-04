using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        class People
        {
            public string name;
            public int age;
            public double size;
        }


        static void Main(string[] args)
        {
            People m1 = new People();
            m1.age = 25;
            m1.name = "Артём";
            m1.size = 180.5;
            People m2 = new People();
            m2.age = 35;
            m2.name = "Иван";
            m2.size = 195.3;
            Console.WriteLine(m1.age + " " +  m1.name + " "  + m1.size);

                    
        }
    }
}
