using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    class UsingAs
    {
        public void usingAs()
        {
            /*
                as is a interesting keyword that cast non-user-defined objects. Instead of throwing an 
                InvalidCastException, it returns a null, so null check is good practice.

                It's equivolant is expression is type ? (type)expression : type(null)
             */

            object something = "Hello";
            Console.WriteLine(something as string);
            Console.WriteLine(something as Nullable<int>);
            Console.WriteLine(something as int?);

            //Console.WriteLine(something as int); won't compile destination type must be a reference
            // or nullable value type
        }

        //This can be used for an object's Equals method
        public override bool Equals(object obj)
        {
            UsingAs customObject = obj as UsingAs;

            if (Object.ReferenceEquals(null, customObject))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
