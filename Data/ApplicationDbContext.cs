using System;
using System.Collections.Generic;
using System.Text;
using ApPets.Common;
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

            builder.Entity<Pet>(build =>
            {
                build.ToTable("tblPets");
                build.HasOne(p => p.User)
                .WithMany(u => u.Pets)
                .HasForeignKey(p => p.UserId);

            });

            builder.Entity<PetType>(build =>
            {
                build.ToTable("tblPetTypes");
                build.HasMany(pt => pt.Pets)
                .WithOne(p => p.PetType)
                .HasForeignKey(p => p.PetTypeId);
            });

            builder.Entity<Ciudad>(build =>
            {
                build.ToTable("tblCiudades");

                build.HasOne(c => c.Estado)
                .WithMany(e => e.Ciudades)
                .HasForeignKey(c => c.IdEstado);
            });

            builder.Entity<Estado>(build =>
            {
                build.ToTable("tblEstados");

                build.HasOne(e => e.Pais)
                .WithMany(p => p.Estados)
                .HasForeignKey(e => e.IdPais);

                build.HasMany(e => e.Users)
                .WithOne(u => u.Estado)
                .HasForeignKey(u => u.IdEstado);
            });

            builder.Entity<Veterinary>(build =>
            {
                build.ToTable("tblVeterinaries");

                build.HasMany(v => v.Services)
                .WithOne(vs => vs.Veterinary)
                .HasForeignKey(u => u.IdVeterinary);


                build.HasOne(v => v.Estado)
                .WithMany(e => e.Veterinaries)
                .HasForeignKey(v => v.IdEstado);
            });

            builder.Entity<VetService>().ToTable("tblVetServices");

            builder.Entity<Pais>().ToTable("tblPaises");

            // builder.Entity<VeterinaryVetService>().HasKey(vvs => new { vvs.VeterinaryId, vvs.VetServiceId });

            // builder.Entity<VeterinaryVetService>()
            //    .HasOne(vvs => vvs.Veterinary)
            //    .WithMany(v => v.VeterinaryVetServices)
            //    .HasForeignKey(vvs => vvs.VeterinaryId);

            // builder.Entity<VeterinaryVetService>()
            //    .HasOne(vvs => vvs.VetService)
            //    .WithMany(vs => vs.VeterinaryVetServices)
            //    .HasForeignKey(vvs => vvs.VetServiceId);
        }
    }

    public class ApPetsUser : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime UpDate { get; set; }
        public DateTime ModDate { get; set; }
        public DateTime Birthdate { get; set; }

        public int IdEstado { get; set; }
        public Estado Estado { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
