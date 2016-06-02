﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator: Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component!=null)
            {
                component.Operation();
            }
        }
    }
}
