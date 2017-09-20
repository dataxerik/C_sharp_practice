using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //new UsingAs().usingAs();
            //new DemoInheritance().ShowOff();
            new UsingAsync().DoSomethingAsync().Wait();

        }
    }
}
