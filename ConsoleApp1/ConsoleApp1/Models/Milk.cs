﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Milk : Product
    {
        public double Volume;
        public double FatRate;

        public Milk(string name) : base(name)
        {

        }
    }
}
