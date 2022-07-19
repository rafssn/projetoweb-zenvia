using Api_projeto_Zenvia.Models.Customer;
using Microsoft.EntityFrameworkCore;

namespace Api_projeto_Zenvia.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options)
             : base(options){ }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
