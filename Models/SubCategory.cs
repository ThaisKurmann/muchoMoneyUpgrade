﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMoneyUpgrade.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }

    }
}
