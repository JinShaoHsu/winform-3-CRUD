using ISpan.EStore.Infra.Extensions;
using ISpan.EStore.Models.Servers;
using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
			
		}
		private void Savebutton_Click(object sender, EventArgs e)
		{
			//取得表單各欄位值
			string account = AccounttextBox.Text;
			string password = PasswordtextBox.Text;
			string name = NametextBox.Text;

			//將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name,
			};
			//針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", AccounttextBox},
				{"Password",PasswordtextBox},
				{ "Name",NametextBox},
			};
			bool isValid = ValidationHelper.Validate(model,map,errorProvider1);
			if(!isValid)return;

			//如果通過驗證,就新增紀錄
			try
			{
				new Userservies().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show("新增失敗,原因:" + ex.Message);
			}

		}
		#region
		//private bool Validate(UserVM model)
		//{
		//	ValidationContext context = new ValidationContext(model, null, null);

		//	List<ValidationResult>errors = new	List<ValidationResult>();

		//	this.errorProvider1.Clear();
		//	bool validateAllProperties = true;
		//	bool isValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
		//	if (!isValid)
		//	{
		//		DisplayErrorsByErrorProvider(errors);
		//	}
		//	return isValid;
		//}
		//private void DisplayErrorsByErrorProvider(List<ValidationResult> errors)
		//{
		//	Dictionary<string,Control>map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
		//	{
		//		{"Account", AccounttextBox},
		//		{"Password",PasswordtextBox},
		//		{ "Name",NametextBox},
		//	};
		//	this.errorProvider1.Clear();
		//	foreach (ValidationResult error in errors)
		//	{
		//		string propName = error.MemberNames.FirstOrDefault();
		//		if(map.TryGetValue(propName, out Control ctrl))
		//		{
		//			this.errorProvider1.SetError(ctrl, error.ErrorMessage);
		//		}
		//	}
		//}
		#endregion 
	}
}
