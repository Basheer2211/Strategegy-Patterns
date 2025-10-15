using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategegy_Patterns
{
    public class Mute : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute");
        }
    }
}
