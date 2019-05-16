using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AthenaeumServer.Models
{
    public partial class AthenaeumContext : DbContext
    {
        public AthenaeumContext()
        {
        }

        public AthenaeumContext(DbContextOptions<AthenaeumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=qnaplatform.db");
            }
        }
    }
}
