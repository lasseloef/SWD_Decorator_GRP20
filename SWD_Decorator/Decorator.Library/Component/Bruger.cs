using System;

namespace Decorator.Library.Component
{
    public class Bruger : IUser
    {
        public void PrintRights()
        {
            Console.WriteLine("User: Bruger");
        }
    }
}
