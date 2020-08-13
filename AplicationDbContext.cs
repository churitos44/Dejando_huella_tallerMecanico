using System;
using Microsoft.EntityFrameworkCore;


namespace taller.AccesoDatos
{
    public class AplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appConfig.json")
                .Builder();
            optionBuilder.UserSqlServer(configuration.GetConnectionString("DefaultConntion"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteTransporte>()
                .Totable("ClienteTRnsporte")
                .Hakey(ct => new { ct.ClienteId, ct.CarroId });
            modelBuilder.Entity<Cliente>()
                .Haskey(ct =>new {ct.ClienteId});;
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<ClienteCarros> ClientesCarros { get; set; }

    }
}
