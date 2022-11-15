using ISpan.EStore.Infra.Extensions;
using ISpan.EStore.Models.Servers;
using ISpan.EStore.Models.ViewModels;
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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void Loginbutton_Click(object sender, EventArgs e)
		{
			//將表單欄位值繫結到view model
			LoginVM model = new LoginVM
			{
				Account = AccounttextBox.Text,
				Password = PasswordtextBox.Text
			};
			//驗證欄位輸入是否正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", AccounttextBox},
				{"Password",PasswordtextBox},
			
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			//判斷帳密是否正確
			bool result = new Userservies().Authenticate(model);
			if(result== false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}
			//若正確,就開啟MainForm
			AccounttextBox.Text = String.Empty;
			PasswordtextBox.Text = String.Empty;

			var frm = new MainForm();
			frm.Owner = this;
			frm.Show();
			this.Hide();
		}
	}
}
