using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WebApp.Models
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Books> Books { get; set; }

    }
}
