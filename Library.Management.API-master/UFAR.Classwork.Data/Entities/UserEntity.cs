using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace UFAR.Classwork.Data.Entities
{
    public record UserEntity:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        // Add other properties as needed
    }
}