using Tyuiu.NasadukJA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.NasadukJA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "красный длинный";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "длинный";
            Assert.AreEqual(wait, res);
        }
    }
}
