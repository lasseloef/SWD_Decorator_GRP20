using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public class AllRightsDecorator : UserDecorator
    {
        public AllRightsDecorator(IUser user) : base(user)
        {

        }
        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine("RETTIGHED: User has full access");
        }
    }
}