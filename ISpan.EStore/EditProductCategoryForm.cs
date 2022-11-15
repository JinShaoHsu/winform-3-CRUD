using ISpan.EStore.Infra.Extensions;
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
	public partial class EditProductCategoryForm : Form
	{
		private int id;
		public EditProductCategoryForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM ProductCategories WHERE Id = @Id";
			var parameter = new SqlParameterBuilder().AddNInt("Id", id).Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameter);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉,找不到要編輯的紀錄");
				this.DialogResult=DialogResult.OK;
				this.Close();
				return;
			}
			
			
			//將欄位放在控制向裡
			DataRow row = data.Rows[0];
			nameTextbox.Text = row.Field<string>("CategoryName");
			displayOrdertextBox.Text =row.Field<int>("DisplayOrder").ToString();
		}

		private void Updatebutton_Click(object sender, EventArgs e)
		{
			string categoryName = nameTextbox.Text;

			int displayorder = displayOrdertextBox.Text.ToInt(-1);

			string sql = @"UPDATE ProductCategories SET CategoryName = @CategoryName,
							DisplayOrder=@DisplayOrder WHERE Id = @Id";
			var parameters = new SqlParameterBuilder().AddNVarchar("CategoryName", 50, categoryName)
				.AddNInt("DisplayOrder", displayorder)
				.AddNInt("Id",this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("您真的要刪除嗎?","刪除紀錄",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)
			{return;}

			string sql = @"DELETE FROM ProductCategories WHERE Id = @Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}
	}

	
}
