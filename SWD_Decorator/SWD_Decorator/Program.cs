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
            UserDecorator BrugerA = new AntalDecorator(basicBruger);
            UserDecorator BrugerB = new PrisDecorator(BrugerA);

            BrugerB.PrintRights();

            Console.WriteLine("");

            //Admin med alle rettigheder
            IUser basicAdmin = new Admin();
            UserDecorator AdminA = new AllRightsDecorator(basicAdmin);

            AdminA.PrintRights();


        }
    }
}
