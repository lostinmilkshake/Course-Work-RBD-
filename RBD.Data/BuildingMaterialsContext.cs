using Microsoft.EntityFrameworkCore;
using System;

namespace RBD.Data
{
    public class BuildingMaterialsContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Types> Types { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialCharacteristic> MaterialCharacteristics { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }

        public BuildingMaterialsContext()
        {
            _connectionString = "Data Source=(localdb)\\Local; Initial Catalog=BuildingMaterials; User Id=Test; Password=1234";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
