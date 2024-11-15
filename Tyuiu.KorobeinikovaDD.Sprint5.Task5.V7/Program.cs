// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task5.V7.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                              *");
Console.WriteLine("* Задание #5                                                                  *");
Console.WriteLine("* Вариант #7                                                                  *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Найти факториал первого целого числа в файле.                               *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask5V7.txt";

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);

Console.ReadKey();