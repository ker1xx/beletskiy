﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beletskiy
{
    internal class Class1
    {
        public Class1(int a,int b,string c,string d)
        {
            id = a;
            role = b;
            nick = c;
            parol = d;

        }
        public int id;
        public int role;
        public string nick;
        public string parol;

    }
}
