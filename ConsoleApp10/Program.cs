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
            private string name;
            private int age;
            private double size;

            //Конструктор класса
            public People(string name, int age, double size)
            {
                this.name = name;
                this.age = age;
                this.size = size;
            }
            //Свойства
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            //Метод
            public void Show ()
            {
                Console.WriteLine(name + " " + age + " " + size);
            }
                
        }


        static void Main(string[] args)
        {
            People man1 = new People("Вася", 38, 168.3);
            People man2 = new People("Дмитрий", 25, 174);
            man1.Name = "Ivan";
            Console.WriteLine(man1.Name);
        }
    }
}
