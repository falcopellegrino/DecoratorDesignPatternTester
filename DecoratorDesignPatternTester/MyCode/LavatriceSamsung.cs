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
    class LavatriceSamsung : Lavatrice
    {
        private bool _programmaVeloce;

        // Constructor
        public LavatriceSamsung(bool programmaVeloce, TipoProgrammaLavatrice tipoProgrammaLavatrice)
        {
            this._programmaVeloce = programmaVeloce;
            this.ProgrammaLavatrice = tipoProgrammaLavatrice;
        }

        public override void Lava()
        {
            Console.WriteLine("\nLavatrice Samsung ----- ");
            Console.WriteLine(" Sto lavando...");
            Console.WriteLine(" Programma lavatrice: {0}", ProgrammaLavatrice.ToString());
            Console.WriteLine(" Programma veloce: {0}", _programmaVeloce);
        }
    }
}
