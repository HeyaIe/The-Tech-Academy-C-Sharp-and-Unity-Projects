﻿using System;

namespace AbstractAssignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void sayName();
    }
}
