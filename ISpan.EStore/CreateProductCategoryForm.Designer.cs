namespace ISpan.EStore
{
	partial class CreateProductCategoryForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.displayOrdertextBox = new System.Windows.Forms.TextBox();
			this.Savebutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "分類名稱";
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(114, 52);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(100, 22);
			this.nameTextbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "顯示順序";
			// 
			// displayOrdertextBox
			// 
			this.displayOrdertextBox.Location = new System.Drawing.Point(114, 89);
			this.displayOrdertextBox.Name = "displayOrdertextBox";
			this.displayOrdertextBox.Size = new System.Drawing.Size(100, 22);
			this.displayOrdertextBox.TabIndex = 1;
			// 
			// Savebutton
			// 
			this.Savebutton.Location = new System.Drawing.Point(138, 140);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 23);
			this.Savebutton.TabIndex = 2;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
			// 
			// CreateProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 201);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.displayOrdertextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextbox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "CreateProductCategoryForm";
			this.Text = "新增商品分類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox displayOrdertextBox;
		private System.Windows.Forms.Button Savebutton;
	}
}