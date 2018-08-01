using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoogleKeepAssignment.Models
{
    public class GoogleKeepContext : DbContext
    {
        public GoogleKeepContext (DbContextOptions<GoogleKeepContext> options)
            : base(options)
        {
        }

        public DbSet<GoogleKeepAssignment.Models.Note> Note { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>()
                .HasKey(c => c.Title);

            modelBuilder.Entity<CheckList>()
                .HasKey(c => new { c.Title, c.CheckListData, c.CheckListStatus });

            modelBuilder.Entity<Label>()
                .HasKey(c => new { c.Title, c.LabelString });
        }
    }
}
