using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
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
		/// объект рандом для случайных чисел.
		/// </summary>
		Random rnd = new Random();

		/// <summary>
		/// коллекция со словами для теста.
		/// </summary>
		static List<string> ALLwords = new List<string>() 
		{ 
			"работа", "коллекция", "торт", "винегрет", "жёсткий", 
			"значок", "инцидент", "новичок", "приукрасить", "престижный"
		};
		/// <summary>
		/// коллекция для одноразового ввода слов в окно.
		/// </summary>
		List<string> words;

		/// <summary>
		/// массив букв которые можно заменить в словах.
		/// </summary>
		string заменяемыеБуквы = "ёуеыаоэяию";

		//поля, где хранятся правильные ответы, для сравнения введённого ответа и исходного слова.
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
		/// случайное слово из коллекции.
		/// </summary>
		/// <remarks>
		/// метод берёт случайное слово из поля, специальной коллекции; удаляет его оттуда, и возвращает.
		/// </remarks>
		/// <returns>случайное слово из временной коллекции типа <see cref="string"/>.</returns>
		private string GetWord()
		{
			string word = words[rnd.Next(words.Count)]; //получение случайного слова из коллекции слов.
			words.Remove(word); //удаление этого слова из коллекции.
			return word; //возврат случайного слова.
		}
		/// <summary>
		/// установка пропуска.
		/// </summary>
		/// <remarks>
		/// метод устанавливает в слово из параметров один пропуск за место случайной гласной, и возвращает его.
		/// </remarks>
		/// <param name="word"> слово, в котором нужно сделать пропуск. </param>
		/// <returns>слово с пропуском типа <see cref="string"/>.</returns>
		private string SetLoose(string word)
		{
			//из-за того что string не разрешает изменять букву в слове по индексу,
			//используется класс StringBuilder.
			StringBuilder worder = new StringBuilder(word); 
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
			return $"{worder}"; //возврат слова с пропуском.
		}

		/// <summary>
		/// начало теста.
		/// </summary>
		private void StartLT()
		{
			//первая строка.
			first = GetWord(); //установка слова из коллекции в поле с ответом.
			firstWord.Text = SetLoose(first); //установка слова с пропуском в окно.
			firstBox.Text = ""; //очистка поля, на случай если там прошлые ответы.
			//вторая строка.
			second = GetWord();
			secondWord.Text = SetLoose(second);
			secondBox.Text = "";
			//третья строка.
			third = GetWord();
			thirdWord.Text = SetLoose(third);
			thirdBox.Text = "";
			//четвёртая строка.
			fourth = GetWord();
			fourthWord.Text = SetLoose(fourth);
			fourthBox.Text = "";
			//пятая строка.
			fifth = GetWord();
			fifthWord.Text = SetLoose(fifth);
			fifthBox.Text = "";

			//запуск таймера.
			timeleft = 30; 
			timelabel.Text = $"{timeleft} секунд.";
			timer1.Start();
		}

		/// <summary>
		/// метод обрабатывающий событие нажатия кнопки "начать тест".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClickStart(object sender, EventArgs e)
		{
			words = new List<string>(ALLwords); //возврат всех слов в коллекцию.
			StartLT(); //запуск теста.
			startButton.Enabled = false; //выключение кнопки старта.
			changeTypeButton.Enabled = false; //выключение кнопки смены типа теста.
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
				timelabel.Text = "гений нашёлся.."; //вывод сообщения в лейбл таймера о победе.
				MessageBox.Show("наверняка калькулятор использовал да?", "ну че гений"); //вывод сообщения о завершении,
				timelabel.Text = $"спидран: 0:{30 - timeleft}"; //установка текста после завершения теста.
				EndTest(); //сток, после окончания теста.
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

				//установка для всех полей с ответами верные ответы,
				firstBox.Text = first;
				secondBox.Text = second;
				thirdBox.Text = third;
				fourthBox.Text = fourth;
				fifthBox.Text = fifth;

				EndTest(); //сток, после окончания теста.
			}
			if (timeleft <= 5) timelabel.ForeColor = Color.Red; //если осталось 5 секунд - установка красного цвета текста таймера.
		}

		/// <summary>
		/// приведение теста в изначальное состояние.
		/// </summary>
		/// <remarks>
		/// метод вызывается обработчиком таймера, когда заканчивается тест, <br/>
		/// устанавливает кнопкам включённое состояние, и, <br/>
		/// если на тексте таймера было меньше 5 секунд, <br/>
		/// из-за чего он становился красным, устанавливается чёрный цвет.
		/// </remarks>
		private void EndTest()
		{
			startButton.Enabled = true; //включение кнопки старта.
			changeTypeButton.Enabled = true; //включение кнопки смены типа теста.
			timelabel.ForeColor = Color.Black; //установка чёрного цвета таймера.
		}

		/// <summary>
		/// метод для проверки всех введённых ответов.
		/// </summary>
		/// <returns>
		/// если все слова будут верными, то возвращается <see langword="true"/>,<br/>
		/// но если хотя бы одно слово будет неверным, то возвращается <see langword="false"/>.
		/// </returns>
		private bool CheckAns()
		{
			if (
				firstBox.Text == first &&
				secondBox.Text == second &&
				thirdBox.Text == third &&
				fourthBox.Text == fourth &&
				fifthBox.Text == fifth
				) return true;
			else return false;
		}

		/// <summary>
		/// событие при фокусировке на поле с ответом.
		/// </summary>
		/// <remarks>
		/// если человек нажимает на поле, куда вводится ответ, <br/>
		/// то выделяется всё значение, которое находится в этом поле, <br/>
		/// а после пользователь может вводить новое значение.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void answer_Enter(object sender, EventArgs e)
		{
			TextBox ansbox = sender as TextBox; //поле с ответом.
			if (ansbox != null) //если поле не null
			{
				string anstxt = ansbox.Text; //значение поля с ответом приведён в тип string.
				int length = anstxt.Length; //получение длины строки с ответом.
				ansbox.Select(0, length); //выделение значения поля в самом поле.
			}
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
			Form1 form = new Form1(); //создание объекта другой формы.
			form.Show(); //отображение формы.
			Thread.Sleep(10); //задержка, для более плавной смены формы.
			Hide(); //скрытие этой формы.
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