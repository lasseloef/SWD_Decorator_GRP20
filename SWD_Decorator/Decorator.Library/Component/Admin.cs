using System;

namespace Decorator.Library.Component
{
    public class Admin : IUser
    {
        public void PrintRights()
        {
            Console.WriteLine("User: Admin");
        }

    }
}