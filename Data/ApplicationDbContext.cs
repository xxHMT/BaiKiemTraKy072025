using Microsoft.EntityFrameworkCore;
using BaiKiemTraKy072025.Models;

namespace BaiKiemTraKy072025.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Student>Students { get; set; }
    }
}