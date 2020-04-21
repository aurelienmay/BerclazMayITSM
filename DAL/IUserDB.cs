﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUserDB
    {
        User GetUserByUID(int uid);
        User GetBalanceByUID(int uid);
    }
}
