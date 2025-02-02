using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Home
    {
        [Key]
        public int HomeID { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Text1 { get; set; }
    }
}
