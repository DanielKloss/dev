using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginController loginController = new LoginController();
            loginController.Login("John.Smith");
            loginController.Login(123);

            AdminLoginController adminLoginController = new AdminLoginController();
            adminLoginController.Login("Jane.Doe");

            Console.ReadLine();
        }
    }
}
