using System;

namespace Decorator.Library.Component
{
    public class Bruger : IUser
    {
        public void PrintUser()
        {
            Console.WriteLine("User: Bruger");
        }
    }
}
