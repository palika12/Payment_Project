using Payment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Payment.Api.Data
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetail>()
                .Property(p => p.PaymentDetailId)
                .ValueGeneratedOnAdd(); // Ensure ID is generated on add
        }
    }
}
