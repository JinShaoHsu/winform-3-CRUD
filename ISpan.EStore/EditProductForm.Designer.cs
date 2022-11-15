namespace ISpan.EStore
{
	partial class EditProductForm
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
			this.Updatebutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.categoryidcomboBox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listpricetextBox = new System.Windows.Forms.TextBox();
			this.productnametextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(80, 204);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(75, 23);
			this.Updatebutton.TabIndex = 4;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(161, 204);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 23);
			this.Deletebutton.TabIndex = 5;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// categoryidcomboBox
			// 
			this.categoryidcomboBox.DataSource = this.productCategoryVMBindingSource1;
			this.categoryidcomboBox.DisplayMember = "CategoryName";
			this.categoryidcomboBox.FormattingEnabled = true;
			this.categoryidcomboBox.Location = new System.Drawing.Point(146, 42);
			this.categoryidcomboBox.Name = "categoryidcomboBox";
			this.categoryidcomboBox.Size = new System.Drawing.Size(142, 20);
			this.categoryidcomboBox.TabIndex = 6;
			this.categoryidcomboBox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource1
			// 
			this.productCategoryVMBindingSource1.DataSource = typeof(ISpan.EStore.Models.ViewModels.ProductCategoryVM);
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.ViewModels.ProductCategoryVM);
			// 
			// listpricetextBox
			// 
			this.listpricetextBox.Location = new System.Drawing.Point(146, 147);
			this.listpricetextBox.Name = "listpricetextBox";
			this.listpricetextBox.Size = new System.Drawing.Size(142, 22);
			this.listpricetextBox.TabIndex = 10;
			// 
			// productnametextBox
			// 
			this.productnametextBox.Location = new System.Drawing.Point(146, 91);
			this.productnametextBox.Name = "productnametextBox";
			this.productnametextBox.Size = new System.Drawing.Size(142, 22);
			this.productnametextBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 11;
			this.label3.Text = "牌價:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "商品名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "分類:";
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 324);
			this.Controls.Add(this.categoryidcomboBox);
			this.Controls.Add(this.listpricetextBox);
			this.Controls.Add(this.productnametextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Name = "EditProductForm";
			this.Text = "EditProductForm";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.ComboBox categoryidcomboBox;
		private System.Windows.Forms.TextBox listpricetextBox;
		private System.Windows.Forms.TextBox productnametextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource1;
	}
}