using Microsoft.EntityFrameworkCore;
using BDGLS.Models;

namespace BDGLS.DataAccess
{
    public class BDGLContext : DbContext
    {
        public BDGLContext(DbContextOptions<BDGLContext> options) : base(options){ }
        public BDGLContext() { }
        public DbSet<UserModel> User { get; set; }
        public DbSet<GameModel> Application { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}