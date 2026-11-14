using Tyuiu.OlontsevAS.Sprint1.Task2.V26.Lib;
namespace Tyuiu.OlontsevAS.Sprint1.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateMinutesSinceStart()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 45;
            var res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(345, res);

        }
    }
}
