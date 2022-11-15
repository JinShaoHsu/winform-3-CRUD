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
	public partial class ProductCategoriesForm : Form
	{
		DataTable categories = new DataTable();
		public ProductCategoriesForm()
		{
			InitializeComponent();
			DisplayProductCateories();
		}
		private void DisplayProductCateories()
		{
			string sql = "SELECT * FROM ProductCategories ORDER BY Displayorder";
			categories = new SqlDbHelper("default").Select(sql, null);

			BindData(categories);
		}
		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductCategoryForm();
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if(result == DialogResult.OK)
			{
				DisplayProductCateories();
			}

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx =e.RowIndex;
			if(rowindx<0)return;
			DataRow row = this.categories.Rows[rowindx];//使用者點到的那筆紀錄
			int id = row.Field<int>("id");//使用者點到的那一筆紀錄的id值
			//把id傳給編輯表單的建構函數
			var frm = new EditProductCategoryForm(id);
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if( result == DialogResult.OK)
			{
				DisplayProductCateories();
			}
		}
	}
}
