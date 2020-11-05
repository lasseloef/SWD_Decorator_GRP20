using System;

namespace Decorator.Library.Component
{
    /*
     * Denne klasse svarer til "ConcreteComponent" i sektion 3 - "Struktur & Anvendelse" i rapporten
     */
    public class Bruger : IUser
    {
        public void PrintRights()
        {
            Console.WriteLine("User: Bruger");
        }
    }
}
