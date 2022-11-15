namespace ISpan.EStore
{
	partial class CreateProductForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.productnametextBox = new System.Windows.Forms.TextBox();
			this.listpricetextBox = new System.Windows.Forms.TextBox();
			this.categoryidcomboBox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Savebutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "分類:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "商品名稱:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "牌價:";
			// 
			// productnametextBox
			// 
			this.productnametextBox.Location = new System.Drawing.Point(155, 111);
			this.productnametextBox.Name = "productnametextBox";
			this.productnametextBox.Size = new System.Drawing.Size(142, 22);
			this.productnametextBox.TabIndex = 1;
			// 
			// listpricetextBox
			// 
			this.listpricetextBox.Location = new System.Drawing.Point(155, 167);
			this.listpricetextBox.Name = "listpricetextBox";
			this.listpricetextBox.Size = new System.Drawing.Size(142, 22);
			this.listpricetextBox.TabIndex = 2;
			// 
			// categoryidcomboBox
			// 
			this.categoryidcomboBox.DataSource = this.productCategoryVMBindingSource;
			this.categoryidcomboBox.DisplayMember = "CategoryName";
			this.categoryidcomboBox.FormattingEnabled = true;
			this.categoryidcomboBox.Location = new System.Drawing.Point(155, 62);
			this.categoryidcomboBox.Name = "categoryidcomboBox";
			this.categoryidcomboBox.Size = new System.Drawing.Size(142, 20);
			this.categoryidcomboBox.TabIndex = 0;
			this.categoryidcomboBox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.ViewModels.ProductCategoryVM);
			// 
			// Savebutton
			// 
			this.Savebutton.Location = new System.Drawing.Point(201, 249);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 23);
			this.Savebutton.TabIndex = 3;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 322);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.categoryidcomboBox);
			this.Controls.Add(this.listpricetextBox);
			this.Controls.Add(this.productnametextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimizeBox = false;
			this.Name = "CreateProductForm";
			this.Text = "新增商品紀錄";
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox productnametextBox;
		private System.Windows.Forms.TextBox listpricetextBox;
		private System.Windows.Forms.ComboBox categoryidcomboBox;
		private System.Windows.Forms.Button Savebutton;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
	}
}