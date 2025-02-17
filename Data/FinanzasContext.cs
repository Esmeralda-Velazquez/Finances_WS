using Microsoft.EntityFrameworkCore;
using FinanzasAPI.Models;

namespace FinanzasAPI.Data
{
    public class FinanzasContext : DbContext
    {
        public FinanzasContext(DbContextOptions<FinanzasContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
