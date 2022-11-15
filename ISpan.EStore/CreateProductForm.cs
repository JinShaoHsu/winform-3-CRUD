using ISpan.EStore.Infra.Extensions;
using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class CreateProductForm : Form
	{
		public CreateProductForm()
		{
			InitializeComponent();
			InitForm();
		}

		private void InitForm()
		{
			//設定 comboBox property
			//Prepend 是在清單上面+1
			//Apend是在清單下面+1
			var sql = "SELECT * FROM ProductCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");
			List<ProductCategoryVM> categories = dbHelper.Select(sql, null).AsEnumerable().Select(row => ToCategoryVM(row))
				//.Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
				.ToList();
			this.categoryidcomboBox.DataSource = categories;
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

		private void Savebutton_Click(object sender, EventArgs e)
		{
			//取得表單各欄位值
			int categoryId = ((ProductCategoryVM)this.categoryidcomboBox.SelectedItem).Id;
			string productname = productnametextBox.Text;
			int listprice = listpricetextBox.Text.ToInt(-1);//如果沒填牌價回傳-1

			//將它們繫結到ViewModel
			ProductVM model = new ProductVM
			{
				CategoryId = categoryId,
				ProductName = productname,
				ListPrice = listprice,
			};
			//針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			if (model.ListPrice < 0) errorMsg += "牌價必須輸入大於或等於零的整數\r\n";
			if(string.IsNullOrEmpty(errorMsg)== false)
			{
				//表示至少一欄有誤
				MessageBox.Show(errorMsg);
				return;//不再往下執行
			}

			//如果通過驗證,就新增紀錄
			string sql = @"INSERT INTO Products
							(CategoryId,ProductName,Listprice)
							VALUES(@CategoryId,@ProductName,@ListPrice)";
			var parameters = new SqlParameterBuilder()
				.AddNInt("CategoryId", model.CategoryId)
				.AddNVarchar("ProductName",50,model.ProductName)
				.AddNInt("Listprice",model.ListPrice)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;

		}
	}
}
