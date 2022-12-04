using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Assassin_sCreedWikiSked.Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext1")
        {
        }

        public virtual DbSet<Serie> Series { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Serie>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.ImgURI)
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.VideoPath)
                .IsUnicode(false);
        }
    }
}
