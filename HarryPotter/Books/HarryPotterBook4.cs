﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Books
{
    public class HarryPotterBook4 : IHarryPotterBook
    {
        public decimal price { get; } = 100;

        public int count { get; set; }
    }
}
