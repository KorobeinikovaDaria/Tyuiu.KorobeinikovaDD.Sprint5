using Tyuiu.KorobeinikovaDD.Sprint5.Task3.V9.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Дарья\AppData\Local\Temp\OutPutFileTask3.bin";
            var res = ds.SaveToFileTextData(0);

            Assert.AreEqual(path, res);
        }
    }
}