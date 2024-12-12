using Tyuiu.ShmelevAV.Sprint6.Task7.V2.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask7V2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
