// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task3.V9.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                         *");
Console.WriteLine("* Задание #3                                                                  *");
Console.WriteLine("* Вариант #9                                                                  *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в      *");
Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль                      *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int x = 3;
Console.WriteLine("x = 3");

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: = " + res);
Console.WriteLine("Создан!");

Console.ReadKey();