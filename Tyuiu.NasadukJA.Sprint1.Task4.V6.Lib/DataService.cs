using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NasadukJA.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Abs(Math.Pow(y, 2) - x) / (x * y);
            return Math.Round(res, 3);
        }
    }
}
