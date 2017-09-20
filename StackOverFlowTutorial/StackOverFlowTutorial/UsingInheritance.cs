using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowTutorial
{
    // You can multiple public class in a .cs that don't use the name of the .cs file
    public class BaseClass
    {
        public virtual void Foo() //Everything must be declared to be overridden
        {
            Console.WriteLine("Foo from BaseClass");
        }

        public void Foo2()
        {
            Console.WriteLine("Foo2 from BaseClass");
        }
    }

    public class DerivedClass: BaseClass
    {
        public override void Foo() //Throws a warning that the method isn't be ovrridden without 'override' keyword
        {
            Console.WriteLine("Foo from Derived class");
        }
    }

    public class DerivedClass2: BaseClass
    {
        // If you want to create a new method with same name of non-overridable method
        // you can use the 'new' keyword to surpress the warning. The method that will
        // be called is the object's reference type not what it points to
        public new void Foo2() 
        {
            Console.WriteLine("Foo2 from DerivedClass2");
        }
    }

    public class DerivedClass3: BaseClass
    {
        // The base class isn't overriden, but any class that inherits from DerivedClass3
        // can override Foo2
        public virtual new void Foo2() 
        {
            Console.WriteLine("Foo from DerivedClass3");
        }
    }

    public class DerivedDerivedClass4: DerivedClass3
    {
        public override void Foo2()
        {
            Console.WriteLine("Foo From DerivedDerivedClass4");
        }
    }

    public class DemoInheritance
    {
        public void ShowOff()
        {
            BaseClass obj1 = new BaseClass();
            obj1.Foo();
            Console.WriteLine(obj1.GetType());
            Console.WriteLine();

            DerivedClass obj2 = new DerivedClass();
            obj2.Foo();
            Console.WriteLine(obj2.GetType());
            Console.WriteLine();

            obj1 = new DerivedClass();
            obj1.Foo();
            Console.WriteLine(obj1.GetType());
            Console.WriteLine();

            BaseClass obj3 = new DerivedClass();
            obj3.Foo();
            Console.WriteLine(obj3.GetType());
            Console.WriteLine();

            ((BaseClass)obj3).Foo();
            Console.WriteLine(obj3.GetType());
            Console.WriteLine();
        }
    }
}
