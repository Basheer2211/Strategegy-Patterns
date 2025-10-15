using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategegy_Patterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck(FlyBevavior flyBevavior,QuackBehavior quackBehavior)
        {
             setFly(flyBevavior);
            setquack(quackBehavior);
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
