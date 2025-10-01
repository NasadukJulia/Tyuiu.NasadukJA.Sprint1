using Tyuiu.NasadukJA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.NasadukJA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 212;
            DataService ds = new DataService();
            int res = ds.FahrenheitToСelsius(x);

            int wait = 100;

            Assert.AreEqual(wait, res);
        }
    }
}
