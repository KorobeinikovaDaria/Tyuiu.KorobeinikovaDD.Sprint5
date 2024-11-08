using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
           string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
           

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            for ( int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6, 2);

                if (x != stopValue)
                {
                    if (x != -1.7)

                    {
                        File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, Convert.ToString(0) + Environment.NewLine);
                    }
                }
                else
                {
                    File.AppendAllText(path, Convert.ToString(y));
                }
            }
            return path;
        }
    }
}
