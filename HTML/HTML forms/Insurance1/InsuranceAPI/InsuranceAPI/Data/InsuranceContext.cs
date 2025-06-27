using Microsoft.EntityFrameworkCore;
using InsuranceAPI.Models;

namespace InsuranceAPI.Data
{
    
        public class InsuranceContext : DbContext
        {
            public InsuranceContext(DbContextOptions<InsuranceContext> options)
                : base(options)
            {
            }
        public DbSet<User> Users { get; set; }
        }

}

