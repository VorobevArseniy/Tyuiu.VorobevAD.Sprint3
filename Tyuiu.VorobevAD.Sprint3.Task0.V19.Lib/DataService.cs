using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task0.V19.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task0V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 1;

            for (int i = 1; i < stopValue; ++i)
            {
                S += Math.Pow((1 / (Math.Cos(i) + 2)), 2);
            }
            return S;
            throw new NotImplementedException();
        }
    }
}
