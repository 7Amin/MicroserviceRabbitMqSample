using Microsoft.EntityFrameworkCore;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}