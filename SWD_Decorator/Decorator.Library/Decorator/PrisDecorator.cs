using System;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public class PrisDecorator : UserDecorator
    {
        public PrisDecorator(IUser user) : base(user)
        {

        }
        public override void PrintRights()
        {
            base.PrintRights();
            PrintPris();
        }

        public void PrintPris()
        {
            Console.WriteLine("RETTIGHED: Pris");
        }
    }
}