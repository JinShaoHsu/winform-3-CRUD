using ISpan.EStore.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.Infra.Extensions
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			//得知要驗證規則
			ValidationContext context = new ValidationContext(model, null, null);
			//用來存放錯誤的集合,因為有可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();
			//驗證model
			errorProvider.Clear();
			bool validateAllProperties = true;//是否驗證所有規則,而非只是驗證Required規則
			bool isValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
			if (!isValid)
			{
				DisplayErrorsByErrorProvider(errors,map,errorProvider);
			}
			return isValid;
		}
		public static void DisplayErrorsByErrorProvider(List<ValidationResult> errors,
			Dictionary<string, Control> map,ErrorProvider errorProvider)
		{
			
			//this.errorProvider.Clear();
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
