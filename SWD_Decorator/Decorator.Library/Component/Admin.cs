using System;

namespace Decorator.Library.Component
{
    public class Admin : IUser
    {
        public void PrintUser()
        {
            Console.WriteLine("User: Admin");
        }

    }
}