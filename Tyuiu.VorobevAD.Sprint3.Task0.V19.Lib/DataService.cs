using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task0.V19.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task0V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;

            for (int i = startValue; i < stopValue; ++i)
            {
                double term = 1 / Math.Cos(i + 2);
                S += Math.Pow(term, 2);
            }
            return S;
            throw new NotImplementedException();
        }
    }
}
