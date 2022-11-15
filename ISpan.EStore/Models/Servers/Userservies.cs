using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.Models.Servers
{
	public class Userservies
	{
		public List<UserIndexVm>GetAll()
		{
			string sql = @"SELECT * FROM Users ORDER BY ID DESC";
			SqlParameter[] parameters = new SqlParameter[] { };
			var dbHelper = new SqlDbHelper("default");
			return  dbHelper.Select(sql, parameters).AsEnumerable()
							.Select(row => ParseToIndexVM(row)).ToList();
		}
		public void Create(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");
			string sql = @"INSERT INTO Users(Account,Password,Name)
						VALUES(@Account,@Password,@Name)";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name",50, model.Name)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account = @Account";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private UserIndexVm ParseToIndexVM(DataRow row)
		{
			return new UserIndexVm
			{
				id = row.Field<int>("id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
		public void Update(UserVM model)
		{
			bool isExists = AccountExists_U(model.Account,model.id);
			if (isExists) throw new Exception("帳號已重複");
			string sql = @"UPDATE Users
			SET  Account=@Account, Password = @Password,Name = @Name WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", model.id)
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool AccountExists_U(string account ,int Id)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account = @Account and Id != @Id";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account).AddNInt("Id",Id)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		internal bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if(user == null)return false;//找不到符合的帳號
			return (user.Password == model.Password);
		}
		public UserVM Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account = @Account";
			var parameter = new SqlParameterBuilder()
				.AddNVarchar("Account",50,account).Build();
			DataTable data = new SqlDbHelper("default").Select(sql,parameter);
			if (data.Rows.Count == 0)
			{
				return null;
			}
			//將找到的一筆紀錄由DataTable 轉換到UserVM
			return ToUserVM(data.Rows[0]);
		}
		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				id = row.Field<int>("id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}

	}
}
