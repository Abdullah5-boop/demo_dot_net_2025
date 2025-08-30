using demoApp0818.Models;
using Microsoft.EntityFrameworkCore;

namespace demoApp0818.Data
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Description = "A journey of self-discovery and dreams.",
                    Price = 15.99m,
                    Category = "Fiction",
                    Stock = 10,
                    CoverImageUrl = "https://example.com/alchemist.jpg"
                },
                new Book
                {
                    BookId = 2,
                    Title = "1984",
                    Author = "George Orwell",
                    Description = "A dystopian novel about surveillance and control.",
                    Price = 12.50m,
                    Category = "Dystopian",
                    Stock = 15,
                    CoverImageUrl = "https://example.com/1984.jpg"
                },
                new Book
                {
                    BookId = 3,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Description = "A novel of racial injustice and childhood innocence.",
                    Price = 18.00m,
                    Category = "Classic",
                    Stock = 20,
                    CoverImageUrl = "https://example.com/mockingbird.jpg"
                },
                new Book
                {
                    BookId = 4,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Description = "A story of wealth, love, and the American Dream.",
                    Price = 14.99m,
                    Category = "Classic",
                    Stock = 8,
                    CoverImageUrl = "https://example.com/gatsby.jpg"
                },
                new Book
                {
                    BookId = 5,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Description = "Romantic novel of manners in 19th century England.",
                    Price = 11.50m,
                    Category = "Romance",
                    Stock = 12,
                    CoverImageUrl = "https://example.com/pride.jpg"
                },
                new Book
                {
                    BookId = 6,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    Description = "A tale of obsession and revenge against a whale.",
                    Price = 16.75m,
                    Category = "Adventure",
                    Stock = 5,
                    CoverImageUrl = "https://example.com/mobydick.jpg"
                },
                new Book
                {
                    BookId = 7,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Description = "The prelude to the Lord of the Rings saga.",
                    Price = 19.99m,
                    Category = "Fantasy",
                    Stock = 25,
                    CoverImageUrl = "https://example.com/hobbit.jpg"
                },
                new Book
                {
                    BookId = 8,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    Description = "A futuristic vision of a controlled society.",
                    Price = 13.40m,
                    Category = "Dystopian",
                    Stock = 9,
                    CoverImageUrl = "https://example.com/bravenewworld.jpg"
                },
                new Book
                {
                    BookId = 9,
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoevsky",
                    Description = "A psychological study of guilt and redemption.",
                    Price = 17.25m,
                    Category = "Classic",
                    Stock = 7,
                    CoverImageUrl = "https://example.com/crime.jpg"
                },
                new Book
                {
                    BookId = 10,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Description = "A coming-of-age story about teenage alienation.",
                    Price = 10.99m,
                    Category = "Classic",
                    Stock = 14,
                    CoverImageUrl = "https://example.com/catcher.jpg"
                }
            );
        }
    }
}
