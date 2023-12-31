﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class UserLogin
    {
        private static UserLogin instance = null;
        private static object _lockobject = new object();s
        public string Userid { get; set; }
        public string Password { get; set; }

        private UserLogin()
        {

        }
        public static UserLogin CreateUser()
        {
            lock (_lockobject)
            {
                if (UserLogin.instance == null)
                {
                    instance = new UserLogin();
                }

            }
            return instance;
        }

    }
}
