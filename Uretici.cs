﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret
{
    class Uretici
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public string KargoyaVer(string city1,string city2)
        {
            return city1 + city2;
        }

        public int ParaIadesiYap(int Fiyat)
        {
            return Fiyat;
        }
    }
}