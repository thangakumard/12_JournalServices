using Journal.DataAccess.Mapping;
using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;

namespace Journal.DataAccess.Repositories.Context
{
    public class JournalContext : DbContext
    {
        public JournalContext()
        {

        }

        public JournalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Activity> Activity { get; set; }

        public DbSet<MoodType> MoodType { get; set; }

        public DbSet<EventType> EventType { get; set; }

        public DbSet<Journals> Journals { get; set; }

        public DbSet<JournalActivity> JournalActivity { get; set; }

        public DbSet<JournalEventType> JournalEventType { get; set; }

        public DbSet<JournalMoodType> JournalMoodType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=RUBINI\SQLEXPRESS;Database =DairyBook; User Id=sa;Password=Pranav@2013");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Users>(new UsersMapping());
            modelBuilder.ApplyConfiguration<Activity>(new ActivityMapping());
            modelBuilder.ApplyConfiguration<MoodType>(new MoodTypeMapping());
            modelBuilder.ApplyConfiguration<EventType>(new EventTypeMapping());
            modelBuilder.ApplyConfiguration<Journals>(new JournalsMapping());
            modelBuilder.ApplyConfiguration<JournalActivity>(new JournalActivityMapping());
            modelBuilder.ApplyConfiguration<JournalEventType>(new JournalEventTypeMapping());
            modelBuilder.ApplyConfiguration<JournalMoodType>(new JournalMoodTypeMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
