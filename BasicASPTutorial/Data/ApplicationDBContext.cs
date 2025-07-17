using Microsoft.EntityFrameworkCore;

namespace BasicASPTutorial.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<BasicASPTutorial.Models.Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BasicASPTutorial.Models.Student>().ToTable("Students");
        }
}
