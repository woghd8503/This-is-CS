﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    class DeepCopy
    {
        public int MyField1;
        public int MyField2;

        public DeepCopy MyClass()
        {
            MyClass newCopy = new DeepCopy();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}