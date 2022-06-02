using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
	public partial class Form2 : Form
	{
		//автоматически созданный конструктор.
		/// <summary>
		/// конструктор формы (окна).
		/// </summary>
		public Form2()
		{
			InitializeComponent();
		}

		//поля
		/// <summary>
		/// массив со словами для теста.
		/// </summary>
		string[] words = 
		{ 
			"работа", "коллекция", "торт", "винегрет", "жёсткий", 
			"значок", "инцидент", "новичок", "приукрасить", "престижный" 
		};

		/// <summary>
		/// массив букв которые можно заменить в словах.
		/// </summary>
		string заменяемыеБуквы = "ёуеыаоэяию";

		/// <summary>
		/// объект рандом для случайных чисел.
		/// </summary>
		Random rnd = new Random();
		
		//методы
		/// <summary>
		/// установка случайного слова с пропуском в лейбл в форме.
		/// </summary>
		/// <param name="location">лейбл в который надо вставить случайное слово.</param>
		private void SetProblem(Label location)
		{
			string word = words[rnd.Next(words.Length)]; //получение случайного слова из массива слов.
			string transformatedWord = SetLoose(word);
			location.Text = transformatedWord;
		}
		/// <summary>
		/// установка одного пропуска за место случайной гласной.
		/// </summary>
		/// <param name="word">слово, в котором нужно сделать пропуск. </param>
		/// <returns>слово с пропуском типа <see cref="string"/>.</returns>
		private string SetLoose(string word)
		{
			StringBuilder worder = new StringBuilder(word);
			bool repeat = true;
			do
			{
				for (int i = 0; i < worder.Length; i++)
				{
					for (int j = 0; j < заменяемыеБуквы.Length; j++)
					{
						if (worder[i] == заменяемыеБуквы[j] && rnd.Next(2) == 1)
						{
							worder[i] = '_';
							repeat = false;
							break;
						}
					}
					if (repeat) break;
				}
			} while (repeat);
			return $"{worder}";
		}







		//важные методы для формы.
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
			Form1 form = new Form1();
			form.Show();
			Thread.Sleep(10);
			Hide();
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