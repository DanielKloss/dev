using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Normal
{
    public class AdminController : UserController
    {
        public void SetPermissions(string username)
        {
            Console.WriteLine("Setting user permissions for user: " + username);
        }
    }
}
