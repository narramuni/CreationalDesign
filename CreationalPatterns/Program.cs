﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserLogin login = UserLogin.CreateUser();
            login.Userid = "Sai";
            login.Password = "password";
            Console.WriteLine("User created successfully");

            UserLogin login2 = UserLogin.CreateUser();
            login2.Userid = "Pavan";
            login2.Password = "password";
            Console.WriteLine("User created successfully");

            Console.ReadLine();
        }
    }
}
