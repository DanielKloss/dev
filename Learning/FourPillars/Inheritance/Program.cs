using Inheritance.Abstract;
using Inheritance.Interface;
using Inheritance.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            userController.Login("John.Smith", "secret");
            //userController.SetPermissions("John.Smith");

            AdminController adminController = new AdminController();
            adminController.Login("Jane.Doe", "pass123");
            adminController.SetPermissions("Jane.Doe");

            SuperAdminController superAdminController = new SuperAdminController();
            superAdminController.Login("Joe.Bloggs", "password");
            superAdminController.SetPermissions("Joe.Bloggs");

            Admin admin = new Admin();
            admin.name = "Jane.Doe";
            admin.role = "admin";

            Seller seller = new Seller();
            seller.name = "John.Smith";
            seller.role = "Seller";

            //User user = new User();

            //DatabaseConnection connection = new DatabaseConnection();
            MicrosoftDatabaseConnection connection = new MicrosoftDatabaseConnection();

            Console.ReadLine();
        }
    }
}
