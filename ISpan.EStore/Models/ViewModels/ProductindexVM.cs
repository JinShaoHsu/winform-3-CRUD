using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.Models.ViewModels
{
	/// <summary>
	/// 供ProductForm使用
	/// </summary>
	public class ProductindexVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
	/// <summary>
	/// 供CreateProductForm,EditProductForm使用
	/// </summary>
	public class ProductVM
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string ProductName { get; set; }
		public int ListPrice { get; set; }
	}
}
