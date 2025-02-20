using System.Collections;
using System.Collections.Generic;

namespace ShoppingMells.Models
{
	public class OrderDetailsVM
	{
        public OrderHeader OrderHeader { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
