﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationObject
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer( Logger logger)
        {
            _logger = logger;  
        }
        public void Install ()
        {
            Console.WriteLine("Ins");
        }
    }
}
