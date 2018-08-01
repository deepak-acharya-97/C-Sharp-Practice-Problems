using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoogleKeepAssignment.Models
{
    public class NotesContext : DbContext
    {
        public NotesContext (DbContextOptions<NotesContext> options)
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
                .HasKey(c => new { c.Title, c.CheckListData });

            modelBuilder.Entity<Label>()
                .HasKey(c => new { c.Title, c.LabelString });
        }
    }
}
