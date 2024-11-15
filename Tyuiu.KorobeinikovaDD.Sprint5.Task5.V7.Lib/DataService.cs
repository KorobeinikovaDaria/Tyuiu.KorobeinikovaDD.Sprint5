using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {

                while ((reader.ReadLine()) != null)
                {
                    double n = Convert.ToDouble(reader.ReadLine());
                    if ( n % 1 == 0)
                        for (int i = 1; i <= n; i++)
                        {
                            if (n > 0)
                            {
                                res *= i;
                                
                            }
                        }
                    break;
                }
                return res;
            }
        }
    }
}
