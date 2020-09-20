namespace TicketBasket.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<EventImage> EventImages { get; set; }
        public DbSet<Events> Eventss { get; set;}
        public DbSet<EventTag> EventTags { get; set; }
        public DbSet<JobApplocation> JobApplocations { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<WishlistEvent> WishlistEvents { get; set; }

        protected override void onModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}