﻿using Example.Entetities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Entetities
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Printuser()
        {
            Console.WriteLine($"ID: {Id}, UserName: {UserName}, Name: {Name}");
        }
    }
}
