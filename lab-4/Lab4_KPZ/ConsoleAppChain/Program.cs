﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryChain;

namespace ConsoleAppChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var supportSystem = new SupportSystem();
            supportSystem.Start();
        }
    }
}
