using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WebApp.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
