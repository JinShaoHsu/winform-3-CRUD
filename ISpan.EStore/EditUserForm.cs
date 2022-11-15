using ISpan.EStore.Infra.Extensions;
using ISpan.EStore.Models.Servers;
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
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM Users WHERE Id = @Id";
			var parameter = new SqlParameterBuilder()
							.AddNInt("Id", id)
							.Build();
			DataTable data = new SqlDbHelper("default")
							.Select(sql, parameter);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉,找不到要編輯的紀錄");
				this.DialogResult = DialogResult.OK;
				//this.Close();
				return;
			}
			UserVM model = ToUserVM(data.Rows[0]);
			AccounttextBox.Text = model.Account;
			PasswordtextBox.Text = model.Password;
			NametextBox.Text = model.Name;
		}
		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}
		private UserVM ToCategoryVM(DataRow row)
		{
			return new UserVM
			{
				id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name")
			};
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string Account = AccounttextBox.Text;
			string Password = PasswordtextBox.Text; 
			string Name = NametextBox.Text;
			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				id = id,
				Account = Account,
				Password = Password,
				Name = Name,
			};

			// 針對ViewModel進行欄位驗證
			#region 舊的
			//string errorMsg = string.Empty;
			//if (string.IsNullOrEmpty(model.Account)) errorMsg += "帳號必填\r\n";
			//if (string.IsNullOrEmpty(model.Password)) errorMsg += "密碼必填\r\n";
			//if (string.IsNullOrEmpty(model.Name)) errorMsg += "姓名必填\r\n";
			//if (string.IsNullOrEmpty(errorMsg) == false)
			//{
			//	//表示至少一欄有錯誤
			//	MessageBox.Show(errorMsg);
			//	return; // 不再向下執行
			//}
			#endregion
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", AccounttextBox},
				{"Password",PasswordtextBox},
				{ "Name",NametextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider2);
			if (!isValid) return;

			//如果通過驗證,就新增紀錄
			try
			{
				new Userservies().Update(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗,原因:"+ex.Message);
			}

			// update record
			//string sql = @"UPDATE Users
			//SET  Account=@Account, Password = @Password,Name = @Name
			//WHERE Id=@Id";

			//var parameters = new SqlParameterBuilder()
			//	.AddNInt("Id", model.id)
			//	.AddNVarchar("Account", 50, model.Account)
			//	.AddNVarchar("Password",50, model.Password)
			//	.AddNVarchar("Name",50,model.Name)
			//	.Build();

			//new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			//this.DialogResult = DialogResult.OK;
		}
		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }

			string sql = @"DELETE FROM Users WHERE Id = @Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}
	}
}
