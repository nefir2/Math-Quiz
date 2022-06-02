using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		/// <summary>
		/// кнопка смены формы.
		/// </summary>
		/// <remarks>
		/// при нажатии на кнопку в форме, закрывается форм2 и открывается форм1.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangeType(object sender, EventArgs e)
		{
			Hide();
			Form1 form = new Form1();
			form.Show();
		}

		/// <summary>
		/// метод для закрытия всей программы, при нажатии на крестик.
		/// </summary>
		/// <remarks>
		/// бывает такое что при закрытии второй открытой формы, программа не завершается. <br/>
		/// для этого сделан этот метод, чтобы закрыть всю программу при закрытии второй формы.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseAll(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}