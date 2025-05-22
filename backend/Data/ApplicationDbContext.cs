using Microsoft.EntityFrameworkCore;
using ToySwap.Api.Models.Entities;

namespace ToySwap.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Toy> Toys { get; set; }
    }
}