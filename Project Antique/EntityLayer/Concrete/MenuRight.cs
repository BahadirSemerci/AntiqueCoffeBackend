using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MenuRight
    {
        [Key]
        public int MenuRightID { get; set; }
        public string? MenuNameRight { get; set; }
        public string? MenuRightSmallPrice { get; set; }
        public string? MenuRightLargePrice { get; set; }
        public string? MenuRightImage { get; set; }
    }
}
