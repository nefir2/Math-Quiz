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
	public partial class Form1 : Form
	{
		//автоматически созданный конструктор.
		/// <summary>
		/// конструктор формы (окна).
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		//поля
		/// <summary>
		/// объект рандом для случайных чисел.
		/// </summary>
		Random rnd = new Random();

		/// <summary>
		/// первое число для примера со сложением.
		/// </summary>
		int plusone;
		/// <summary>
		/// второе число для примера со сложением.
		/// </summary>
		int plustwo;

		/// <summary>
		/// первое число для примера с вычитанием.
		/// </summary>
		int minusone;
		/// <summary>
		/// второе число для примера с вычитанием.
		/// </summary>
		int minustwo;

		/// <summary>
		/// первое число для примера с умножением.
		/// </summary>
		int timeone;
		/// <summary>
		/// второе число для примера с умножением.
		/// </summary>
		int timetwo;

		/// <summary>
		/// первое число для примера с делением.
		/// </summary>
		int divideone;
		/// <summary>
		/// второе число для примера с делением.
		/// </summary>
		int dividetwo;

		//методы
		/// <summary>
		/// начало математического теста.
		/// </summary>
		public void StartMQ()
        {
			//				пример со сложением.

			//добавление случайных чисел в поля.
			plusone = rnd.Next(51);
			plustwo = rnd.Next(51);
			//вывод полученных чисел в форму (окно).
			plusLeftLabel.Text = $"{plusone}";
			plusRightLabel.Text = $"{plustwo}";
			//установка в поле ответа значение 0.
			sum.Value = 0;

			//				пример с вычитанием.

			//добавление случайных чисел в поля.
			minusone = rnd.Next(1, 101);
			minustwo = rnd.Next(1, minusone);
			//вывод полученных чисел в форму (окно).
			minusLeftLabel.Text = $"{minusone}";
			minusRightLabel.Text = $"{minustwo}";
			//установка в поле ответа значение 0.
			difference.Value = 0;

			//				пример с умножением.

			//добавление случайных чисел в поля.
			timeone = rnd.Next(2, 11);
			timetwo = rnd.Next(2, 11);
			//вывод полученных чисел в форму (окно).
			timesLeftLabel.Text = $"{timeone}";
			timesRightLabel.Text = $"{timetwo}";
			//установка в поле ответа значение 0.
			product.Value = 0;

			//				пример с делением.

			//добавление случайных чисел в поля.
			dividetwo = rnd.Next(2, 11);
			int half = rnd.Next(2, 11);
			divideone = dividetwo * half;
			//вывод полученных чисел в форму (окно).
			dividedLeftLabel.Text = $"{divideone}";
			dividedRightLabel.Text = $"{dividetwo}";
			//установка в поле ответа значение 0.
			quotient.Value = 0;
		}

		/// <summary>
		/// обработчик события нажатия на кнопку "начать тест".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
			StartMQ();
			startButton.Enabled = false;
        }
    }
}