using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    class ModificaPerAsciugare : Decorator
    {
        bool _predispostaPerDiventareAsciugatrice = false;

        // Constructor
        public ModificaPerAsciugare(Lavatrice lavatrice)
            :base(lavatrice)
        {
        }

        public void RendiAsciugatrice(bool rendiAsciugatrice)
        {
            this._predispostaPerDiventareAsciugatrice = rendiAsciugatrice;
        }

        public override void Lava()
        {
            base.Lava();

            if(_predispostaPerDiventareAsciugatrice)
            {
                Console.WriteLine(" Posso anche asciugare...");
            }
            else
            {
                Console.WriteLine(" Non posso asciugare!");
            }
        }
    }
}
