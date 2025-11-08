using Tyuiu.SherenkovIR.Sprint4.Task7.V30.Lib;
namespace Tyuiu.SherenkovIR.Sprint4.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "684259137159648";
            int rows = 5;
            int cols = 3;
            int wait = 73728;
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(wait, res);
        }
    }
}
