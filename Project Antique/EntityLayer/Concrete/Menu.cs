﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string? MenuName { get; set; }
        public string? SmallPrice { get; set; }
        public string? LargePrice { get; set; }
        public string?  MenuImage { get; set; }
      
       
    }
}

