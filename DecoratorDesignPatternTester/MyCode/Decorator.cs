using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator : Lavatrice
    {
        protected Lavatrice lavatrice;

        // Constructor
        public Decorator(Lavatrice lavatrice)
        {
            this.lavatrice = lavatrice;
        }

        public override void Lava()
        {
            lavatrice.Lava();
        }
    }
}
