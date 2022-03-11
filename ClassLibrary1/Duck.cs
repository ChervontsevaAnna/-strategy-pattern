using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

       public string swim()
        {
            return "Бульк " + this.GetType();
        }
        public abstract string display();
        public string PerformQuack()
        {
            return quackBehavior.quack();
        }
        public string PerformFly()
        {
            return flyBehavior.fly();
        }
        public FlyBehavior SetFlyBehavior(FlyBehavior flyBehav)
        {
            flyBehavior = flyBehav;
            return flyBehavior;
        }
        public QuackBehavior SetQuackBehavior(QuackBehavior quackBehav)
        {
            quackBehavior = quackBehav;
            return quackBehavior;
        }

    }
}
