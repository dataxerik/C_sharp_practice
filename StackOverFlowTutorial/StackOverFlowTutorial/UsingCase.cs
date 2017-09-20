using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    class UsingCase
    {
        enum Permissions { Read, Write };

        public void UsingCaseExample()
        {
            
            switch (GetRequestedPermission())
            {
                case Permissions.Read:
                    Console.WriteLine("Read Access");
                    break;

                case Permissions.Write:
                    Console.WriteLine("Write Access");
                    goto case Permissions.Read;
            
            }
        }

        private Permissions GetRequestedPermission() {
            return Permissions.Read;
        }
    }
}
