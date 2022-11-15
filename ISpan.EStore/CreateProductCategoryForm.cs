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
	public partial class CreateProductCategoryForm : Form
	{
		public CreateProductCategoryForm()
		{
			InitializeComponent();
		}

		private void Savebutton_Click(object sender, EventArgs e)
		{
			string categoryName = nameTextbox.Text;

			int displayorder = displayOrdertextBox.Text.ToInt(-1);

			string sql = @"INSERT INTO ProductCategories(CategoryName,DisplayOrder)VALUES(@CategoryName,@DisplayOrder)";
			var parameters = new SqlParameterBuilder().AddNVarchar("CategoryName", 50, categoryName)
				.AddNInt("DisplayOrder",displayorder).Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;

		}
	}
}
