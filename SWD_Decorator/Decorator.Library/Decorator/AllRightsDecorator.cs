using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    /*
     * Klassen svarer til "ConcreteDecorator" eller "OtherConcreteDecorator" i sektion 3 - "Struktur & Anvendelse" i rapporten
     */
    public class AllRightsDecorator : UserDecorator
    {
        public AllRightsDecorator(IUser user) : base(user)
        {

        }

        public override void PrintRights()
        {
            //Dette metode kald svarer til PrintRights() metoden i UserDecorator, som printer USER PrintRights() metoden
            //Altså endten Bruger's eller Admin's
            base.PrintRights();
            //Decorators egen print metode
            PrintAllRights();
        }

        public void PrintAllRights()
        {
            Console.WriteLine("RETTIGHED: User has full access");
        }
    }
}