namespace ISpan.EStore
{
	partial class EditProductCategoryForm
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
			this.Deletebutton = new System.Windows.Forms.Button();
			this.displayOrdertextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Updatebutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(138, 119);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 23);
			this.Deletebutton.TabIndex = 3;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// displayOrdertextBox
			// 
			this.displayOrdertextBox.Location = new System.Drawing.Point(114, 68);
			this.displayOrdertextBox.Name = "displayOrdertextBox";
			this.displayOrdertextBox.Size = new System.Drawing.Size(100, 22);
			this.displayOrdertextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "顯示順序";
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(114, 31);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(100, 22);
			this.nameTextbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "分類名稱";
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(57, 119);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(75, 23);
			this.Updatebutton.TabIndex = 2;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
			// 
			// EditProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 177);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.displayOrdertextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextbox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "EditProductCategoryForm";
			this.Text = "編輯商品分類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.TextBox displayOrdertextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Updatebutton;
	}
}