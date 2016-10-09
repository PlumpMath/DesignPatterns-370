﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory
{
    interface IUserOperation
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
