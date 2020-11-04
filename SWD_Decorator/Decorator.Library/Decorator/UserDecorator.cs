using System.Collections.Generic;
using System.Text;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    public abstract class UserDecorator : IUser
    {
        private readonly IUser _user;

        public UserDecorator(IUser user)
        {
            _user = user;
        }

        public virtual void PrintUser()
        {
           _user.PrintUser();
        }
    }
}
