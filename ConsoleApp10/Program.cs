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
            // Поля класса
            public string name;
            public int age;
            public double size;

            //Конструктор класса
            public People(string name, int age, double size)
            {
                this.name = name;
                this.age = age;
                this.size = size;
            }
            public void Show ()
            {
                Console.WriteLine(name + " " + age + " " + size);
            }
                
        }


        static void Main(string[] args)
        {
            People man1 = new People("Вася", 38, 168.3);
            People man2 = new People("Дмитрий", 25, 174);
            man1.Show();
            man2.Show();
        }
    }
}
