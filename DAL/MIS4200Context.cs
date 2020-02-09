using System;
using System.Collections.Generic;
using System.Data.Entity;
using lr547315MIS4200.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace lr547315MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,lr547315MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

    /*public System.Data.Entity.DbSet<lr547315MIS4200.Models.customer> Customer { get; set; }

        public System.Data.Entity.DbSet<lr547315MIS4200.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<lr547315MIS4200.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<lr547315MIS4200.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<lr547315MIS4200.Models.Instructor> Instructors { get; set; }*/

}