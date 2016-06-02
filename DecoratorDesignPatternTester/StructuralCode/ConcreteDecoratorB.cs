using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddBehavior()
        {
        }
    }
}
