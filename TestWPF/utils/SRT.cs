﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestWPF.utils
{
    public class SRT
    {
        public static void Run()
        {
            string key = ConfigurationManager.AppSettings["APIKey"];
        }
    }
}
