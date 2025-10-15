using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategegy_Patterns
{
    public class FlyWithNoway : FlyBevavior
    {
        public void Fly()
        {
            Console.WriteLine("it can't fly.");
        }
    }
}
