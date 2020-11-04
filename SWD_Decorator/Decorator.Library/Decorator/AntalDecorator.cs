using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public class AntalDecorator : UserDecorator
    {
        public AntalDecorator(IUser user):base(user)
        {

        }
        public override void PrintRights()
        {
            base.PrintRights();
            PrintAntal();
        }

        public void PrintAntal()
        {
            Console.WriteLine("RETTIGHED: Antal");
        }
    }
}