using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    public record BookEntity:BaseEntity
    {
        

        [Required]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public AuthorEntity Author { get; set; }

        public string Genre { get; set; }
    }
}
