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

		/// <summary>
		/// оставшееся время.
		/// </summary>
		/// <remarks>
		/// поле, где хранится число оставшегося времени.
		/// </remarks>
		int timeleft;

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


			//				начало теста
			//запуск таймера при запуске теста.
			timeleft = 30;
			timelabel.Text = $"{timeleft} секунд.";
			timer1.Start();
		}

		/// <summary>
		/// проверка ответов.
		/// </summary>
		/// <remarks>
		/// проверяет поля для ввода ответов.
		/// </remarks>
		/// <returns>
		/// <see langword="true"/> если все ответы верны, и<br/>
		/// <see langword="false"/> если хотя бы один ответ не верный.
		/// </returns>
		private bool CheckAns()
		{
			if  ( //если введены правильные ответы для
				plusone   + plustwo   == sum.Value        && //сложения и
				minusone  - minustwo  == difference.Value && //для вычитания и
				timeone   * timetwo   == product.Value    && //для умножения и
				divideone / dividetwo == quotient.Value      //для деления:
				) return true; //возврат true,
			else  return false; //иначе возврат false.
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

		/// <summary>
		/// обработчик тика таймера.
		/// </summary>
		/// <remarks>
		/// каждую секунду проверяются ответы и оставшееся время.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (CheckAns()) //если все ответы верны:
			{
				timer1.Stop(); //останавливается таймер,

				//добавлено не по заданию.
				timelabel.Text = "гений нашёлся.."; //вывод сообщения в лейбл таймера о победе.

				MessageBox.Show("наверняка калькулятор использовал да?", "ну че гений"); //выводится сообщение о завершении,
				startButton.Enabled = true; //включается кнопки старта.
			}
			else if (timeleft > 0) //иначе если время ещё осталось:
			{
				timeleft--; //вычитается секунда из таймера,
				timelabel.Text = $"{timeleft} секунд."; //вывод оставшегося времени.
			}
			else //если нет верных ответов и не осталось времени:
			{
				timer1.Stop(); //остановка таймера,
				timelabel.Text = "лашпет!"; //вывод сообщения в label для таймера,
				MessageBox.Show("за временем надо следить.", "не повезло"); //меседжбокс с сообщением об опоздании,

				//установка для всех полей с ответами верные ответы
				sum.Value = plusone + plustwo;          //суммы,
				difference.Value = minusone - minustwo; //вычитания,
				product.Value = timeone * timetwo;      //умножения,
				quotient.Value = divideone / dividetwo; //деления,

				//включение кнопки старта.
				startButton.Enabled = true;
			}
		}

		/// <summary>
		/// событие при нажатии Enter в поле с ответом.
		/// </summary>
		/// <remarks>
		/// если человек нажимает Enter, то выделяется всё поле, а после пользователь может вводить новое значение.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void answer_Enter(object sender, EventArgs e)
        {
			NumericUpDown ansbox = sender as NumericUpDown; //поле с ответом.
			if (ansbox != null) //если поле не null
			{
				string ansval = $"{ansbox.Value}"; //значение поля с ответом приведён в тип string.
				int length = ansval.Length; //получение длины строки с ответом.
				ansbox.Select(0, length); //выделение значения поля в самом поле.
			}
		}
    }
}