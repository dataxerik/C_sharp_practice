using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    class UsingAsync
    {
        public async Task DoSomethingAsync()
        {
            Console.WriteLine("Starting a useless process...");
            Stopwatch stopwatch = Stopwatch.StartNew();
            int delay = await UselessProcessAsync(1000);
            stopwatch.Stop();
            Console.WriteLine("A Useless process took {0} milliseconds to execute.", stopwatch.ElapsedMilliseconds);
        }

        public async Task<int> UselessProcessAsync(int x)
        {
            await Task.Delay(x);
            return x;
        }
    }
}
