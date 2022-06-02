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
		static List<string> ALLwords = new List<string>() 
		{ 
			"работа", "коллекция", "торт", "винегрет", "жёсткий", 
			"значок", "инцидент", "новичок", "приукрасить", "престижный"
		};
		/// <summary>
		/// коллекция в которой можно удалять слова без потери слов.
		/// </summary>
		List<string> words;

		/// <summary>
		/// массив букв которые можно заменить в словах.
		/// </summary>
		string заменяемыеБуквы = "ёуеыаоэяию";

		/// <summary>
		/// объект рандом для случайных чисел.
		/// </summary>
		Random rnd = new Random();

		/// <summary>
		/// первое слово.
		/// </summary>
		string first;
		/// <summary>
		/// второе слово.
		/// </summary>
		string second;
		/// <summary>
		/// третье слово.
		/// </summary>
		string third;
		/// <summary>
		/// четвёртое слово.
		/// </summary>
		string fourth;
		/// <summary>
		/// пятое слово.
		/// </summary>
		string fifth;

		/// <summary>
		/// оставшееся время.
		/// </summary>
		/// <remarks>
		/// поле, где хранится число оставшегося времени.
		/// </remarks>
		int timeleft;

		//методы
		/// <summary>
		/// случайное слово.
		/// </summary>
		/// <remarks>
		/// метод берёт случайное слово из коллекции, удаляет его оттуда, и возвращает.
		/// </remarks>
		/// <returns>случайное слово из коллекции тип <see cref="string"/></returns>
		private string GetWord()
        {
			string word = words[rnd.Next(words.Count)]; //получение случайного слова из массива слов.
			words.Remove(word);
			return word;
		}
		/// <summary>
		/// установка в слове одного пропуска за место случайной гласной.
		/// </summary>
		/// <param name="word">слово, в котором нужно сделать пропуск. </param>
		/// <returns>слово с пропуском типа <see cref="string"/>.</returns>
		private string SetLoose(string word)
		{
			StringBuilder worder = new StringBuilder(word); //из-за того что string не разрешает изменять букву в слове
															//используется класс StringBuilder
			bool repeat = true; //если не установится ни одного пропуска,
			do					//то нужно снова пройтись по буквам слова
			{					//и попытаться установить пропуск.
				for (int i = 0; i < worder.Length; i++)
				{ //цикл букв слова.
					for (int j = 0; j < заменяемыеБуквы.Length; j++)
					{ //цикл разрешённых для замены букв.
						if (worder[i] == заменяемыеБуквы[j] && i != worder.Length - 1 && rnd.Next(2) == 1)
						{ //если буква совпадает с разрешённой буквой, не является последней, и случайная цифра (из 0 или 1) равна единице:
							//устанавливается за место буквы пропуск
							worder[i] = '_'; //для этого действия и нужен был StringBuilder.
							repeat = false; //выход из цикла do { } while () и внешнего for () { }
							break; //выход из этого цикла for () { }
						}
					}
					if (!repeat) break; //выход из внешнего цикла for () { }
				}
			} while (repeat); //выход из цикла do { } while ()
			return $"{worder}"; //возврат слова с пропуском
		}

		/// <summary>
		/// ответ для проверки всех ответов.
		/// </summary>
		/// <returns>
		/// если все слова будут верными, то возвращается <see langword="true"/>,<br/>
		/// но если хотя бы одно слово будет неверным, то возвращается <see langword="false"/>.
		/// </returns>
		private bool CheckAns()
		{
			if (firstBox.Text  == first   &&
				secondBox.Text == second  &&
				thirdBox.Text  == third   &&
				fourthBox.Text == fourth  &&
				fifthBox.Text  == fifth
				) return true;
			else return false;
		}

		/// <summary>
		/// начало теста.
		/// </summary>
		private void StartLT()
        {
			first = GetWord();
			firstWord.Text = SetLoose(first); //установка слова с пропуском слова с пропуском.
			firstBox.Text = ""; //очистка поля при начале

			second = GetWord();
			secondWord.Text = SetLoose(second);
			secondBox.Text = "";

			third = GetWord();
			thirdWord.Text = SetLoose(third);
			thirdBox.Text = "";

			fourth = GetWord();
			fourthWord.Text = SetLoose(fourth);
			fourthBox.Text = "";

			fifth = GetWord();
			fifthWord.Text = SetLoose(fifth);
			fifthBox.Text = "";


			//запуск таймера при запуске теста.
			timeleft = 30; 
			timelabel.ForeColor = Color.Black; //установка чёрного цвета таймера
			timelabel.Text = $"{timeleft} секунд.";
			timer1.Start();
		}

		/// <summary>
		/// метод обрабатывающий событие нажатия кнопки "начать тест"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClickStart(object sender, EventArgs e)
		{
			words = new List<string>(ALLwords); //возврат всех слов в коллекцию
			StartLT();
			startButton.Enabled = false;
			changeTypeButton.Enabled = false;
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
				changeTypeButton.Enabled = true;
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
				firstBox.Text = first;
				secondBox.Text = second;
				thirdBox.Text = third;
				fourthBox.Text = fourth;
				fifthBox.Text = fifth;

				//включение кнопки старта.
				startButton.Enabled = true;
				changeTypeButton.Enabled = true;
			}
			if (timeleft <= 5) timelabel.ForeColor = Color.Red; //если осталось 5 секунд - установка красного цвета текста таймера.
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