using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    public record TransactionEntity:BaseEntity 
    {
        [Required]
        public int LibraryId { get; set; }

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
