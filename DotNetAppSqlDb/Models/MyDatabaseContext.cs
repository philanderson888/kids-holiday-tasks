using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class MyDatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyDatabaseContext() : base("name=KidsHolidayTasks")
        {
        }

        public DbSet<Todo> Todoes { get; set; }

        public DbSet<Todo2> Todos2 { get; set; }

        public DbSet<KidsTodo> KidsTodoes { get; set; }




        public virtual DbSet<Task> Tasks { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<User> Users { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.Category);
        }

        public System.Data.Entity.DbSet<DotNetAppSqlDb.Models.HolidayTask> HolidayTasks { get; set; }
    }
}
