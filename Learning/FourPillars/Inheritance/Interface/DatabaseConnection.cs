using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interface
{
    public interface DatabaseConnection
    {
        bool OpenConnectionToDatabase(string url);
    }
}
