using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RBD.Data
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        
        [MaxLength(150)]
        public string Address { get; set; }
        
        [MaxLength(50)]
        public string Email { get; set; }
        
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
