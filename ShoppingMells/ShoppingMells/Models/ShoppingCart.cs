﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingMells.Models
{
	public class ShoppingCart
	{
		public ShoppingCart()
		{
			Count = 1;
		}
		[Key]
		public int Id { get; set; }
		public string ApplicationUserId { get; set; }
		[ForeignKey("ApplicationUserId")]
		public ApplicationUser ApplicationUser { get; set; }
		public int ProductId { get; set; }
		[ForeignKey("ProductId")]
		public Product Product { get; set; }
		public int Count { get; set; }
		[NotMapped]
		public double Price { get; set; }
	}
}
