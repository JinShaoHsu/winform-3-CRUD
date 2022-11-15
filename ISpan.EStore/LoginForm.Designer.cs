namespace ISpan.EStore
{
	partial class LoginForm
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
			this.Loginbutton = new System.Windows.Forms.Button();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Loginbutton
			// 
			this.Loginbutton.Location = new System.Drawing.Point(181, 124);
			this.Loginbutton.Name = "Loginbutton";
			this.Loginbutton.Size = new System.Drawing.Size(75, 23);
			this.Loginbutton.TabIndex = 2;
			this.Loginbutton.Text = "Login";
			this.Loginbutton.UseVisualStyleBackColor = true;
			this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(114, 28);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(142, 22);
			this.AccounttextBox.TabIndex = 0;
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(114, 72);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.Size = new System.Drawing.Size(142, 22);
			this.PasswordtextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "密碼:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "帳號:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 216);
			this.Controls.Add(this.Loginbutton);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.Text = "登入系統";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Loginbutton;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}