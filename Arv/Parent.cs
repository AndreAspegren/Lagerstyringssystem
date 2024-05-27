﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Parent(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        
        protected internal virtual void show()
        {
            Console.WriteLine($"{Id} {Name} {Description}");
        }
    }
}
