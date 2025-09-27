using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.DAL.Entities
{
    public partial class ShoeModel : DbContext
    {
        public ShoeModel()
            : base("name=ShoeModel")
        {
        }

        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<bill_detail> bill_detail { get; set; }
        public virtual DbSet<discount_product> discount_product { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<user_> user_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.link)
                .IsUnicode(false);

            modelBuilder.Entity<user_>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user_>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user_>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
