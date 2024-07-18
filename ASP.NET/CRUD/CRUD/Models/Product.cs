﻿using System.ComponentModel.DataAnnotations;
namespace CRUD.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[Range(0, 50000)]
		public decimal Price { get; set; }
		[Required]
		[Range(0,50)]
		public int Quantity { get; set; }

	}
}
