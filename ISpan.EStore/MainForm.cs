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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void 維護商品ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductsForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護商品類別ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductCategoriesForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new UserForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
