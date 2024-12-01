using Tyuiu.ShmelevAV.Sprint6.Task0.V1.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.103;
            Assert.AreEqual(wait, res);
        }
    }
}