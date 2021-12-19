using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RBD.Data
{
    public class Warehouse : IEntity
    {
        public int Id { get; set; }
        
        [Required]
        public int MaterialId { get; set; }
        
        [Required]
        public Material Material { get; set; }
        
        [Required]
        public int SupplierId { get; set; }
        
        [Required]
        public Supplier Supplier { get; set; }
        
        [Required]
        public bool IsAvailable { get; set; }
        
        public int Ammount { get; set; }
    }
}
