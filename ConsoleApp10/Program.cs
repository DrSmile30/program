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
            private string secondname;
            private int age;
            private double size;


            //Конструктор класса
            public People(string name, string secondname, int age, double size)
            {
                this.name = name;
                this.secondname = secondname;
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

            public string Secondname
            {
                get
                {
                    return secondname;
                }
                set
                {
                    secondname = value;
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            
            public double Size
            {
                get
                {
                    return size;
                }
                set
                {
                    size = value;
                }
            }
        


            //Метод
            public void Show()
            {
                Console.WriteLine(Name + " " + Secondname + " " + Age + " " + Size);
            }

        }


        static void Main(string[] args)
        {
            People man1 = new People("Вася", "Ivanov", 38, 168.3);
            People man2 = new People("Дмитрий", "Vasin", 25, 174);
            man1.Name = "Ivan";
            man1.Secondname = "Petrov";
            man2.Show();
            //man2.Age-
            //man2.age-обращаемся к полю

            
        }
    }
}
