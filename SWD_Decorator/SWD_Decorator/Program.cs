using System;
using Decorator.Library.Component;
using Decorator.Library.Decorator;

namespace SWD_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bruger med delvise rettigheder
            IUser basicBruger = new Bruger();

            //Wrapper basicBruger i 2 forskellige decorators, og objektet får tildelt begge rettigheder.
            UserDecorator brugerA = new AntalDecorator(basicBruger);
            UserDecorator brugerB = new PrisDecorator(brugerA);

            //Kaldet til PrintRights() metoden vil foregå som vist på SD diagrammet i sektion 3 - "Struktur & Anvendelse"
            //og både antal og pris rettigheden vil blive printet.
            brugerB.PrintRights();

            Console.WriteLine("");

            //Admin med alle rettigheder
            IUser basicAdmin = new Admin();
            UserDecorator adminA = new AllRightsDecorator(basicAdmin);

            adminA.PrintRights();


        }
    }
}
