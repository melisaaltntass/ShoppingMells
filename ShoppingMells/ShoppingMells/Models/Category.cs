using System.ComponentModel.DataAnnotations;

namespace ShoppingMells.Models
{
	public class Category
	{
		[Key]
        public int Id { get; set; }
		[Required]
        public string Name { get; set; }
    }
}
