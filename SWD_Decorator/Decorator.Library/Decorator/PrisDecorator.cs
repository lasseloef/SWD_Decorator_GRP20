using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public class PrisDecorator : UserDecorator
    {
        public PrisDecorator(IUser user) : base(user)
        {

        }
        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine("RETTIGHED: Pris");
        }
    }
}