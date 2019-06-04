using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static int[] Input()
        {
            const int len=5;
            int[] massive = new int[len];
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine("Введите " + i + " число: ");
                massive[i] = int.Parse(Console.ReadLine());
            }
            return massive;
        }
        static void Sort(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive.Length; j++)
                {
                    if(massive[i]<massive[j])
                    {
                        int a = massive[i];
                        massive[i] = massive[j];
                        massive[j] = a;
                        Console.WriteLine(a);
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            int[]massive = Input();
            Sort(massive);
        }
    }
}
