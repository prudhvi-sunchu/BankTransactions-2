using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BankTransactions.Models;

namespace BankTransactions.Models
{
    public class TransactionDbContext:IdentityDbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {

        }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
