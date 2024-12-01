using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShmelevAV.Sprint6.Task0.V1.Lib
{
    public class DataService : ISprint6Task0V1
    {
        public double Calculate(int x)
        {
            double res = x / (Math.Pow(x, 3) + 2);
            return Math.Round(res, 3);
        }
    }
}
