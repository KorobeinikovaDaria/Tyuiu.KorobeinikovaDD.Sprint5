// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task0.V27.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                            *");
Console.WriteLine("* Задание #0                                                                  *");
Console.WriteLine("* Вариант #27                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Дано выражение, нужно вычислить его значение при х = 3 и результат          *");
Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt                              *");
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

