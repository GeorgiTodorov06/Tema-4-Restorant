using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tema_4_Restorant.Models;

namespace Tema_4_Restorant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Table> Table { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}