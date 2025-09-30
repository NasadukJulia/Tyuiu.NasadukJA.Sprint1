using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NasadukJA.Sprint1.Task3.V11.Lib
{
    public class DataService : ISprint1Task3V11
    {
        public double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double value = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);

            if (value < 0)
                value = -value;

            double area = 0.5 * value;

            area = ((int)(area * 1000 + 0.5)) / 1000.0;

            return area;
        }
    }
}
