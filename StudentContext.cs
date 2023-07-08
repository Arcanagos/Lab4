using Lab4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab4
{
    public class StudentContext : IdentityDbContext<UserEntity,
UserRole, int>
    {
        public StudentContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; } = null!;
    }
}
