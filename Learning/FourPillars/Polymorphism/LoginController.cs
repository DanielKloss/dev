using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class LoginController
    {
        public virtual void Login(string username)
        {
            Console.WriteLine("Logging in with username: " + username);
        }

        public virtual void Login(int id)
        {
            Console.WriteLine("Logging in with id: " + id);
        }

        public virtual void Login(string email, int reference)
        {
            Console.WriteLine("Logging in with email: " + email + " and reference " + reference);
        }
    }
}
