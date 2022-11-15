using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class ProductsForm : Form
	{
		private ProductindexVM[] products = null;
		public ProductsForm()
		{
			InitializeComponent();
			InitForm();
			//顯示商品紀錄
			DisplayProducts();
		}

		private void InitForm()
		{
			//設定 comboBox property
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

			//Prepend 是在清單上面+1
			//Apend是在清單下面+1
			var sql = "SELECT * FROM ProductCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");
			List<ProductCategoryVM> categories = dbHelper.Select(sql, null).AsEnumerable().Select(row => ToCategoryVM(row))
				.Prepend(new ProductCategoryVM { Id = 0,CategoryName = String.Empty})
				.ToList();
			this.comboBox1.DataSource = categories;
		}

		private ProductCategoryVM ToCategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder")
			};
		}

		private  void DisplayProducts()
		{
			string sql = @"select p.Id,p.ProductName,p.ListPrice,c.CategoryName from products p
							inner join ProductCategories c on p.CategoryId = c.Id";
			//加入where
			SqlParameter[] parameters = new SqlParameter[] { };
			//取得篩選值
			int categoryId = ((ProductCategoryVM)comboBox1.SelectedItem).Id;
			if(categoryId > 0)
			{
				sql += " WHERE CategoryId = @CategoryId";
				parameters = new SqlParameterBuilder().AddNInt("CategoryId",categoryId).Build();
			}



			sql += " Order by C.Displayorder, P.ProductName";
			var dbHelper = new SqlDbHelper("default");
			products = dbHelper.Select(sql, parameters).AsEnumerable().Select(row => ParseToIndexVM(row)).ToArray();
			BindData(products);
		}

		private void BindData(ProductindexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private ProductindexVM ParseToIndexVM(DataRow row)
		{
			return new ProductindexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}

		private void Searchbutton1_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			ProductindexVM row = this.products[rowindx];
			//使用者點到的那筆紀錄
			int id = row.Id;
			//使用者點到的那一筆紀錄的id值
			//把id傳給編輯表單的建構函數
			var frm = new EditProductForm(id);
			//frm.Show();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

	}


}
