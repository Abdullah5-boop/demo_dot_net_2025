using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace demoApp0818.Migrations
{
    /// <inheritdoc />
    public partial class newtow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "CoverImageUrl", "Description", "Price", "Stock", "Title" },
                values: new object[,]
                {
                    { 1, "Paulo Coelho", "Fiction", "https://example.com/alchemist.jpg", "A journey of self-discovery and dreams.", 15.99m, 10, "The Alchemist" },
                    { 2, "George Orwell", "Dystopian", "https://example.com/1984.jpg", "A dystopian novel about surveillance and control.", 12.50m, 15, "1984" },
                    { 3, "Harper Lee", "Classic", "https://example.com/mockingbird.jpg", "A novel of racial injustice and childhood innocence.", 18.00m, 20, "To Kill a Mockingbird" },
                    { 4, "F. Scott Fitzgerald", "Classic", "https://example.com/gatsby.jpg", "A story of wealth, love, and the American Dream.", 14.99m, 8, "The Great Gatsby" },
                    { 5, "Jane Austen", "Romance", "https://example.com/pride.jpg", "Romantic novel of manners in 19th century England.", 11.50m, 12, "Pride and Prejudice" },
                    { 6, "Herman Melville", "Adventure", "https://example.com/mobydick.jpg", "A tale of obsession and revenge against a whale.", 16.75m, 5, "Moby Dick" },
                    { 7, "J.R.R. Tolkien", "Fantasy", "https://example.com/hobbit.jpg", "The prelude to the Lord of the Rings saga.", 19.99m, 25, "The Hobbit" },
                    { 8, "Aldous Huxley", "Dystopian", "https://example.com/bravenewworld.jpg", "A futuristic vision of a controlled society.", 13.40m, 9, "Brave New World" },
                    { 9, "Fyodor Dostoevsky", "Classic", "https://example.com/crime.jpg", "A psychological study of guilt and redemption.", 17.25m, 7, "Crime and Punishment" },
                    { 10, "J.D. Salinger", "Classic", "https://example.com/catcher.jpg", "A coming-of-age story about teenage alienation.", 10.99m, 14, "The Catcher in the Rye" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);
        }
    }
}
