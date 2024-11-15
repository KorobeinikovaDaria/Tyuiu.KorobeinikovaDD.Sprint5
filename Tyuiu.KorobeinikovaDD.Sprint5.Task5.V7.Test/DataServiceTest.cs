using Tyuiu.KorobeinikovaDD.Sprint5.Task5.V7.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}