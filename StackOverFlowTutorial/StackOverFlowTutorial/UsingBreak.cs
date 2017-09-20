using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    class UsingBreak
    {
        public static IEnumerable<int> GetNumbers()
        {
            int i = 0;
            while (true)
            {
                if(i < 10)
                {
                    yield return i++;
                } else
                {
                    yield break; // breaks the while and stops the function
                }
            }
            // This line will not be executed
        }
        public void ForGoToBreak()
        {
            //bool shouldBreak = false;

            while(true)
            {
                if (true)
                {
                    goto endAllLooping;
                }
            }

        endAllLooping:;
        }
    }
}
