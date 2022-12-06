using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Assassin_sCreedWikiSked.Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext4")
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .Property(e => e.Audio)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.ImageUri)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.MotherLand)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.DateOfDeath)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.Killer)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.APlaceOfDeath)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.Affiliation)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.Appearances)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ImageUri)
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.ImgURI)
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.VideoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Weapon>()
                .Property(e => e.ImageUri)
                .IsUnicode(false);
        }
    }
}
