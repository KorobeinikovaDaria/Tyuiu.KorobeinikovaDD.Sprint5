using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int res = 0; 

            string[] words = content.Split(new char[] { ' ', 'n', 'r', 't' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (int.TryParse(words[i], out int number) && number >= 100 && number <= 999)
                {
                    res++; 
                }
               
            }
            return res;
        }

    }
}

