// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task1.V14.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                     *");
Console.WriteLine("* Задание #1                                                                  *");
Console.WriteLine("* Вариант #14                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5, 5],       *");
Console.WriteLine("* произвести проверку на ноль и результат сохранить в текстовый файл          *");
Console.WriteLine("* OutPutFileTask0.txt                                                         *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: = " + res);
Console.WriteLine("Создан!");

Console.ReadKey();
