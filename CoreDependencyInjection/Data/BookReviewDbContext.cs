using Microsoft.EntityFrameworkCore;

namespace CoreDependencyInjection.Data
{
    public class BookReviewDbContext : DbContext
    {
        public BookReviewDbContext(DbContextOptions<BookReviewDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookReview> BookReviews { get; set; }
    }
}
