using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategegy_Patterns
{
   public abstract class Duck
    {
        private FlyBevavior flyBevavior;
        private QuackBehavior QuackBehavior;
        public void performfly()
        {
            flyBevavior.Fly();
        }
        public void performQuack()
        {
            QuackBehavior.Quack();
        }
        public void setFly(FlyBevavior flyBevavior)
        {
            this.flyBevavior = flyBevavior;
        }
        public void setquack(QuackBehavior QuackBehavior)
        {
            this.QuackBehavior = QuackBehavior;
        }
        public abstract void Display();
    }
}
