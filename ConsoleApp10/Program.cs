using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        abstract class Animal
        {
            private string name;

            public Animal(string name)
            {
                this.name = name;
            }
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
            public void Sound()
            {

            }
        }
        class Dog : Animal
        {
            private string poroda;

            public Dog(string name, string poroda)
                : base(name)
            {
                this.Name = name;
                this.poroda = poroda;
            }

            public string Poroda
            {
                get
                {
                    return poroda;
                }
                set
                {
                    poroda = value;
                }


            }
            public void Sound()
            {
                Console.WriteLine("Гав");
            }


        }
        class Cat : Animal
        {
            private string color;

            public Cat(string name, string color)
                : base(name)
            {
                this.Name = name;
                this.color = color;
            }
            public string Color
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }
            public void Sound()
            {
                Console.WriteLine("Мяу");
            }



        }
        class Bird : Animal
        {
            private int speed;
            private double size;

            public Bird(string name,int speed,double size)
                : base(name)
            {
                this.Name = name;
                this.speed = speed;
                this.size = size;
            }
            public int Speed
            {
                get
                {
                    return speed;
                }
                set
                {
                    speed = value;
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
            public void Sound()
            {
                Console.WriteLine("Чик-чирик");
            }

        }




        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Шарик", "Овчарка");
            Cat cat1 = new Cat("Мурка", "Черный");
            Bird bird1 = new Bird("Кеша", 28, 5.5);
            dog1.Sound();
            cat1.Sound();
            bird1.Sound();
        }
    }
}
