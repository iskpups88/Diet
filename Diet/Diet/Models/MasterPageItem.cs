﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Models
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public MasterPageItem(string title)
        {
            this.Title = title;
        }
    }
}
