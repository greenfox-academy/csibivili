﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTday.Excercises
{
    public class Greeter
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public string Greeting()
        {
            return String.Format("Oh, hi there {0}, my dear {1}!", Name, Title);
        }
    }
}
