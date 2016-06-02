using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = DecoratorDesignPatternTester.StructuralCode;
using Real = DecoratorDesignPatternTester.RealWorldCode;
using My = DecoratorDesignPatternTester.MyCode;

namespace DecoratorDesignPatternTester
{
    // Definition
    // Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Component (LibraryItem)
    //      defines the interface for objects that can have responsibilities added to them dynamically. 
    //  - ConcreteComponent (Book, Video)
    //      defines an object to which additional responsibilities can be attached. 
    //  - Decorator (Decorator)
    //      maintains a reference to a Component object and defines an interface that conforms to Component's interface. 
    //  - ConcreteDecorator (Borrowable)
    //      adds responsibilities to the component. 

    /// <summary>
    /// MainApp startup class
    /// for Decorator Design Pattern
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Decorator pattern which dynamically adds extra functionality to an existing object.
            Structural.ConcreteComponent c = new Structural.ConcreteComponent();
            Structural.ConcreteDecoratorA d1 = new Structural.ConcreteDecoratorA();
            Structural.ConcreteDecoratorB d2 = new Structural.ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real-world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Decorator pattern in which 'borrowable' functionality is added to existing library items (books and videos). 

            // Create book
            Real.Book book = new Real.Book("Marquez", "L'amore ai tempi del colera", 5);
            book.Display();

            // Create video
            Real.Video video = new Real.Video("Tarantino", "Le iene", 5, 100);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Real.Borrowable borrowVideo = new Real.Borrowable(video);
            borrowVideo.BorrowItem("Franco");
            borrowVideo.BorrowItem("Marco");

            borrowVideo.Display();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            My.LavatriceLG lavatriceLG = new My.LavatriceLG(true, My.TipoProgrammaLavatrice.Bianchi);
            lavatriceLG.Lava();

            My.LavatriceSamsung lavatriceSamsung = new My.LavatriceSamsung(true, My.TipoProgrammaLavatrice.Colorati);
            lavatriceSamsung.Lava();

            My.ModificaPerAsciugare lavatriceModificataLG = new My.ModificaPerAsciugare(lavatriceLG);
            My.ModificaPerAsciugare lavatriceModificataSamsung = new My.ModificaPerAsciugare(lavatriceSamsung);

            lavatriceModificataLG.RendiAsciugatrice(true);
            lavatriceModificataSamsung.RendiAsciugatrice(false);

            lavatriceModificataLG.Lava();
            lavatriceModificataSamsung.Lava();

            // Wait for user
            Console.ReadKey();
            #endregion

        }
    }
}
