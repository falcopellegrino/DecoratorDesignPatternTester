using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class ConcreteComponent: Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
