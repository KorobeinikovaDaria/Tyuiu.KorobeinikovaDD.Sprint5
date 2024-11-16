// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task6.V27.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Обработка текстовых файлов                                            *");
Console.WriteLine("* Задание #6                                                                  *");
Console.WriteLine("* Вариант #27                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("*Найти количество трехзначных чисел в заданной строке.                        *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask6V27.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
int res = ds.LoadFromDataFile(path);
Console.WriteLine(res);



Console.ReadKey();
