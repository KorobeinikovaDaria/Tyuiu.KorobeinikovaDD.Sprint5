using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string[] str = path.Split(',');
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                var line = reader.ReadLine();
                while (line != null)
                    {
                     double n = Convert.ToDouble(line);
                     for (int i = 1; i <= n; i++)
                        {
                            res *= i;
                        }
                        break;
                    }
             
                return res;
            }
        }
    }
}
