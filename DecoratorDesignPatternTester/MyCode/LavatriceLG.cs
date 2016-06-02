using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class LavatriceLG : Lavatrice
    {
        private bool _caricoLeggero;

        // Constructor
        public LavatriceLG(bool caricoLeggero, TipoProgrammaLavatrice tipoProgrammaLavatrice)
        {
            this._caricoLeggero = caricoLeggero;
            this.ProgrammaLavatrice = tipoProgrammaLavatrice;
        }

        public override void Lava()
        {
            Console.WriteLine("\nLavatrice LG ----- ");
            Console.WriteLine(" Sto lavando...");
            Console.WriteLine(" Programma lavatrice: {0}", ProgrammaLavatrice.ToString());
            Console.WriteLine(" Carico leggero: {0}", _caricoLeggero);
        }
    }
}
