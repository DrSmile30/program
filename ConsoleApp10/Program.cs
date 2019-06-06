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
            public abstract void Sound();
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
            public override void Sound()
            {
                Console.WriteLine("Гав");
            }


        }
        class Cat : Animal
        {
            private string color;
            private int[] bd;

            public Cat(string name, string color, int[] bd)
                : base(name)
            {
                this.Name = name;
                this.color = color;
                this.bd = bd;

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
            public override void Sound()
            {
                Console.WriteLine("Мяу");
            }



        }
        class Bird : Animal
        {
            private int speed;
            private double size;

            public Bird(string name, int speed, double size)
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
            public override void Sound()
            {
                Console.WriteLine("Чик-чирик");
            }

        }




        static void Main(string[] args)
        {
            Animal a = new Dog("Шарик", "Овчарка");
            a.Sound();
            a = new Cat("Мурка", "Черный", new int[] { 1, 2, 3 });
            a.Sound();
            a = new Bird("Кеша", 28, 5.5);
            a.Sound();

        }
    }
}
