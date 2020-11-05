using System.Collections.Generic;
using System.Text;
using Decorator.Library.Component;

namespace Decorator.Library.Decorator
{
    /*
     * Klassen svarer til "Decorator" i sektion 3 - "Struktur & Anvendelse" i rapporten
     */
    public abstract class UserDecorator : IUser
    {
        private readonly IUser _user;

        public UserDecorator(IUser user)
        {
            _user = user;
        }

        public virtual void PrintRights()
        {
           _user.PrintRights();
        }
    }
}
