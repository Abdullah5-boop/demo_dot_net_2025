using System.Diagnostics;
using demoApp0818.Data;
using demoApp0818.DTO;
using demoApp0818.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoApp0818.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookDBContext _db;

        public HomeController(ILogger<HomeController> logger, BookDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        // Home Page (Book Cart)
        public IActionResult Index()
        {
            // Fetch all books from DB
            List<Book> books = _db.Books.ToList();
            return View(books);
        }
        [HttpDelete]
        public IActionResult DeleteRecord(int id)
        {
            var item = _db.Books.Find(id); // Find the record by id
            if (item == null)
            {
                return NotFound(); // Return 404 if item doesn't exist
            }

            _db.Books.Remove(item); // Remove the item
            _db.SaveChanges();      // Commit changes to database

            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult details(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookId == id);
            return View(book);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddBook()
        {
            //Console.WriteLine("AddBook called with book: " + book.Title);
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(BookDTO book)
        {
            if (ModelState.IsValid)
            {
                // Save to DB
                Console.WriteLine("AddBook called with book: " + book.Title);
                Book newBook = new Book()
                {
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    Price = book.Price,
                    Category = book.Category,
                    Stock = book.Stock,
                    CoverImageUrl ="www.yourtube.com"

                };
                _db.Books.Add(newBook);
                _db.SaveChanges();
                // Redirect to Index after successful addition
                return RedirectToAction("Index");
            }
            // If model state is invalid, return the same view with validation errors
            return View(book);





        }
       
    }
}





