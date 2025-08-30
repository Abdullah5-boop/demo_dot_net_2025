using System.ComponentModel.DataAnnotations;

namespace demoApp0818.DTO
{
    public class BookDTO
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0.0, 9999.99)]
        public decimal Price { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

      
    }

}
