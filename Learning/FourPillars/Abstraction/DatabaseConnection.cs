﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class DatabaseConnection
    {
        public abstract void ConnectToDatabase(string url);
    }
}
