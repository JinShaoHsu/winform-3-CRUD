namespace ISpan.EStore
{
	partial class EditUserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.Passwordlabel = new System.Windows.Forms.Label();
			this.Accountlabel = new System.Windows.Forms.Label();
			this.Updatebutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Namelabel = new System.Windows.Forms.Label();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.userVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(149, 87);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.Size = new System.Drawing.Size(142, 22);
			this.PasswordtextBox.TabIndex = 1;
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(149, 46);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(142, 22);
			this.AccounttextBox.TabIndex = 0;
			// 
			// Passwordlabel
			// 
			this.Passwordlabel.AutoSize = true;
			this.Passwordlabel.Location = new System.Drawing.Point(66, 90);
			this.Passwordlabel.Name = "Passwordlabel";
			this.Passwordlabel.Size = new System.Drawing.Size(32, 12);
			this.Passwordlabel.TabIndex = 19;
			this.Passwordlabel.Text = "密碼:";
			// 
			// Accountlabel
			// 
			this.Accountlabel.AutoSize = true;
			this.Accountlabel.Location = new System.Drawing.Point(66, 56);
			this.Accountlabel.Name = "Accountlabel";
			this.Accountlabel.Size = new System.Drawing.Size(32, 12);
			this.Accountlabel.TabIndex = 17;
			this.Accountlabel.Text = "帳號:";
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(86, 182);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(75, 23);
			this.Updatebutton.TabIndex = 3;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(167, 182);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 23);
			this.Deletebutton.TabIndex = 4;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 19;
			this.label4.Text = "牌價:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(149, 136);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 22);
			this.textBox1.TabIndex = 18;
			// 
			// Namelabel
			// 
			this.Namelabel.AutoSize = true;
			this.Namelabel.Location = new System.Drawing.Point(66, 136);
			this.Namelabel.Name = "Namelabel";
			this.Namelabel.Size = new System.Drawing.Size(32, 12);
			this.Namelabel.TabIndex = 19;
			this.Namelabel.Text = "姓名:";
			// 
			// NametextBox
			// 
			this.NametextBox.Location = new System.Drawing.Point(149, 136);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(142, 22);
			this.NametextBox.TabIndex = 2;
			// 
			// userVMBindingSource
			// 
			this.userVMBindingSource.DataSource = typeof(ISpan.EStore.Models.ViewModels.UserVM);
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 279);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.Namelabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Passwordlabel);
			this.Controls.Add(this.Accountlabel);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Name = "EditUserForm";
			this.Text = "EditUserForm";
			((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.Label Passwordlabel;
		private System.Windows.Forms.Label Accountlabel;
		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.BindingSource userVMBindingSource;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.ErrorProvider errorProvider2;
	}
}