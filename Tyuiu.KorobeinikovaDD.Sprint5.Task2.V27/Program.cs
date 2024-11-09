// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint5.Task2.V27.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Класс File. Запись cтруктурированных данных в текстовый файл          *");
Console.WriteLine("* Задание #2                                                                  *");
Console.WriteLine("* Вариант #27                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями *");
Console.WriteLine("* с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить  *");
Console.WriteLine("* в файл OutPutFileTask2.csv и вывести на консоль.                            *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

int rows;
Console.WriteLine("Введите количество cтрок в массиве: ");
rows = Convert.ToInt32(Console.ReadLine());

int columns;
Console.WriteLine("Введите количество столбцов в массиве: ");
columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*******************************************************************************");
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"Введите {i},{j} элемент массива: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t ");
    }
}
Console.WriteLine();


Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл: = " + res);
Console.WriteLine("Создан!");

Console.ReadKey();
