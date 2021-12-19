using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RBD.Data
{
    public class Material : IEntity
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Required]
        public int MaterialTypeId { get; set; }
        
        [Required]
        public Types MaterialType { get; set; }
    }
}
