using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Context
{
    public class ToDoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ToDoDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet <ToDo> Tasks { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
