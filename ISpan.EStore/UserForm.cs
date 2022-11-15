using ISpan.EStore.Models.Servers;
using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class UserForm : Form
	{
		private UserIndexVm[] users = null;
		public UserForm()
		{
			InitializeComponent();
			DisplayProducts();
			
		}
		private void DisplayProducts()
		{
			//string sql = @"SELECT Id ,Account,Password,Name FROM Users";

			//SqlParameter[] parameters = new SqlParameter[] { };

			//var dbHelper = new SqlDbHelper("default");
			//users = dbHelper.Select(sql, parameters).AsEnumerable().Select(row => ParseToIndexVM(row)).ToArray();
			users = new Userservies().GetAll().ToArray();
			BindData(users);
		}
		private void BindData(UserIndexVm[] data)
		{
			dataGridView1.DataSource = data;
		}
		//private UserIndexVm ParseToIndexVM(DataRow row)
		//{
		//	return new UserIndexVm
		//	{
		//		id = row.Field<int>("id"),
		//		Account = row.Field<string>("Account"),
		//		Password = row.Field<string>("Password"),
		//		Name = row.Field<string>("Name"),
		//	};
		//}
		
		private UserVM ToCategoryVM(DataRow row)
		{
			return new UserVM
			{
				id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			UserIndexVm row = this.users[rowindx];
			//使用者點到的那筆紀錄
			int id = row.id;
			//使用者點到的那一筆紀錄的id值
			//把id傳給編輯表單的建構函數
			var frm = new EditUserForm(id);
			//frm.Show();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}

		}
	}

}
