using employee_payroll.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employee_payroll.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor for runtime DI
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Parameterless constructor for design-time tools
        
        public DbSet<Employee> employees { get; set; }
        public DbSet<Payroll> payrolls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.employee)
                .WithMany(e => e.payroll_history)
                .HasForeignKey(p => p.employee_id);

            
        }

        
    }
}