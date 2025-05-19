using MyFirstWebApp.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Infrastructure.Entities
{
	public class Car
	{
		[Key]
		public int Id { get; set; }
		[Required]
        public int Year { get; set; }
		[Required]
        public string Make { get; set; }
		[Required]
		public string Model { get; set; }
        [Required]
        public BodyStyle BodyStyle { get; set; }
		[Required]
        public Condition Condition { get; set; }
		[Required]
		public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
    }
}
