using System.Diagnostics;
using Tyuiu.KorobeinikovaDD.Sprint5.Task0.V27.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\�����\AppData\Local\Temp\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);
            
            Assert.AreEqual(path, res);
        }

    }
}