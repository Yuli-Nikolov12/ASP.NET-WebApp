using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WebApp.Models
{
    public class Books
    {
        [Key]
        public int BooksId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int Pages { get; set; }
        public int Published { get; set; }

        public virtual Authors Author { get; set; }

        public virtual Categories Category { get; set; }
    }
}
