using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class Lavatrice
    {
        private TipoProgrammaLavatrice _programmaLavatrice;

        //Property
        public TipoProgrammaLavatrice ProgrammaLavatrice
        {
            get { return _programmaLavatrice; }
            set { _programmaLavatrice = value; }
        }

        public abstract void Lava();
    }
}
