using BonTemps.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BonTemps.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Reservations)
                .WithOne(r => r.ApplicationUser)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ReservationTable>()
                .HasKey(rt => new { rt.ReservationId, rt.TableId });
            builder.Entity<ReservationTable>()
                .HasOne(rt => rt.Reservation)
                .WithMany(r => r.ReservationTables)
                .HasForeignKey(rt => rt.ReservationId);
            builder.Entity<ReservationTable>()
                .HasOne(rt => rt.Table)
                .WithMany(t => t.ReservationTables)
                .HasForeignKey(rt => rt.TableId);

            builder.Entity<ReservationMenu>()
                .HasKey(rm => new { rm.ReservationId, rm.MenuId });
            builder.Entity<ReservationMenu>()
                .HasOne(rm => rm.Reservation)
                .WithMany(r => r.ReservationMenus)
                .HasForeignKey(rm => rm.ReservationId);
            builder.Entity<ReservationMenu>()
                .HasOne(rm => rm.Menu)
                .WithMany(r => r.ReservationMenus)
                .HasForeignKey(rm => rm.MenuId);

            builder.Entity<DishMenu>()
                .HasKey(dm => new { dm.DishId, dm.MenuId });
            builder.Entity<DishMenu>()
                .HasOne(dm => dm.Dish)
                .WithMany(d => d.DishMenus)
                .HasForeignKey(dm => dm.DishId);
            builder.Entity<DishMenu>()
                .HasOne(dm => dm.Menu)
                .WithMany(m => m.DishMenus)
                .HasForeignKey(dm => dm.MenuId);

            builder.Entity<Dish>()
                .HasOne(d => d.Category)
                .WithOne(c => c.Dish)
                .HasForeignKey<Category>(c => c.DishRef);

            builder.Entity<AllergenDish>()
                .HasKey(ad => new { ad.AllergenId, ad.DishId });
            builder.Entity<AllergenDish>()
                .HasOne(ad => ad.Allergen)
                .WithMany(a => a.AllergenDishes)
                .HasForeignKey(ad => ad.AllergenId);
            builder.Entity<AllergenDish>()
                .HasOne(ad => ad.Dish)
                .WithMany(d => d.AllergenDishes)
                .HasForeignKey(ad => ad.DishId);
        }

        public DbSet<BonTemps.Models.Menu> Menu { get; set; }

        public DbSet<BonTemps.Models.Dish> Dish { get; set; }

        public DbSet<BonTemps.Models.Reservation> Reservation { get; set; }

        public DbSet<BonTemps.Models.Category> Category { get; set; }

        public DbSet<BonTemps.Models.Allergen> Allergen { get; set; }
    }
}
