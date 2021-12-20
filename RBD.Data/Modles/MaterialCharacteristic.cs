using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RBD.Data
{
    public class MaterialCharacteristic : IEntity
    {
        public int Id { get; set; }
        
        public int MaterialId { get; set; }
        
        [Required]
        public Material Material { get; set; }
        
        public int Strength { get; set; }
        
        public float Density { get; set; }
        
        public float Porosity { get; set; }
        
        public float FireReistance { get; set; }
    }
}
