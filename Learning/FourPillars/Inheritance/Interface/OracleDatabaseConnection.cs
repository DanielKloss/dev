﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interface
{
    class OracleDbConnection : DatabaseConnection
    {
        public bool OpenConnectionToDatabase(string url)
        {
            throw new NotImplementedException();
        }
    }
}
