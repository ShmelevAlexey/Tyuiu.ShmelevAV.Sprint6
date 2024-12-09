using Tyuiu.ShmelevAV.Sprint6.Task5.V8.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedLibrary()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V8.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[res.Length];
            wait[0] = -13;
            wait[1] = -19;
            wait[2] = -9.82;
            wait[3] = -9.71;
            wait[4] = -0.11;
            wait[5] = -17.36;
            wait[6] = -12;
            wait[7] = -12.35;
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}