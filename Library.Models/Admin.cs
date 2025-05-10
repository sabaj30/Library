using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceLibrary.Library.Models
{
    public class Admin 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public User? User { get; set; }

    }
}
