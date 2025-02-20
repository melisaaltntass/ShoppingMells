using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingMells.Models
{
	public class ApplicationUser:IdentityUser
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Surname { get; set; }
		public string Adres { get; set; }
		public string Sehir { get; set; }
		public string Semt { get; set; }
		public string PostaKodu { get; set; }
		[NotMapped]
		public string Role { get; set; }
	}
}

