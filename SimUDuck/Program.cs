using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MallardDuck();
            Duck duck2 = new ReadheaddDuck();
            Duck duck3 = new RubberDuck();
            Duck duck4 = new DecoyDuck();
            Duck[] massiveDuck = new Duck[] { duck1, duck2, duck3, duck4};
            foreach (Duck d in massiveDuck)
            {
                Console.WriteLine(d.display());
                Console.WriteLine(d.swim());
                if (d is Flyable) 
                {
                    Console.WriteLine((d as Flyable).fly());
                }
                if (d is Quackable)
                {
                    Console.WriteLine((d as Quackable).quack());
                }

            }
           
            Console.ReadLine();

        }
    }
}
