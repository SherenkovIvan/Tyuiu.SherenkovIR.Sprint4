using Tyuiu.SherenkovIR.Sprint4.Task2.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint4.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 4, 5, 3, 4, 1, 6, 2, 4, 5, 5, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 375;

            Assert.AreEqual(wait, res);
        }
    }
}
