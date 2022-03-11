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
                Console.WriteLine($"{d.swim() } " + $"{d.display()}" + $"{d.PerformFly()} " + $"{d.PerformQuack()}");
            }

            FlyBehavior flyBehavior = new FlyNoWay();
            QuackBehavior quackBehavior = new Squeak();
            duck1.SetQuackBehavior(quackBehavior);
            duck1.SetFlyBehavior(flyBehavior);

            Console.WriteLine($"{duck1.display()} " + $"{duck1.PerformFly()} " + $"{duck1.PerformQuack()}");

            Console.ReadLine();
        }
    }
}
