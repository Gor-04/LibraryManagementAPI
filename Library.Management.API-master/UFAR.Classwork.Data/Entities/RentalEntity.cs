using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    public class RentalEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public UserEntity User { get; set; }

        [Required]
        public int BookId { get; set; }

        public BookEntity Book { get; set; }

        [Required]
        public DateTime RentalDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        
    }
}
