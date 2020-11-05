using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    /*
     * Klassen svarer til "ConcreteDecorator" eller "OtherConcreteDecorator" i sektion 3 - "Struktur & Anvendelse" i rapporten
     */
    public class AntalDecorator : UserDecorator
    {
        public AntalDecorator(IUser user):base(user)
        {

        }
        public override void PrintRights()
        {
            //Dette metode kald svarer til PrintRights() metoden i UserDecorator, som printer USER PrintRights() metoden
            //Altså enten Bruger's eller Admin's
            base.PrintRights();
            //Decorators egen print metode
            PrintAntal();
        }

        public void PrintAntal()
        {
            Console.WriteLine("RETTIGHED: Antal");
        }
    }
}