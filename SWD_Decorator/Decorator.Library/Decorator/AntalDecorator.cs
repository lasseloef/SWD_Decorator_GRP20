using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public class AntalDecorator : UserDecorator
    {
        public AntalDecorator(IUser user):base(user)
        {

        }
        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine("RETTIGHED: Antal");
        }
    }
}