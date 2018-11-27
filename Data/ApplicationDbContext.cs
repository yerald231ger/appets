using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApPets.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApPetsUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
            builder.Entity<ApPetsUser>().ToTable("tblUser");
            builder.Entity<IdentityRole>().ToTable("tblRole");
            builder.Entity<IdentityUserClaim<string>>().ToTable("tblUserClaim");
            builder.Entity<IdentityUserRole<string>>().ToTable("tblUserRole");
            builder.Entity<IdentityUserLogin<string>>().ToTable("tblUserLogin");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("tblRoleClaim");
            builder.Entity<IdentityUserToken<string>>().ToTable("tblUserToken");
        }
    }

    public class ApPetsUser : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime UpDate { get; set; }
        public DateTime ModDate { get; set; }
    }
}
