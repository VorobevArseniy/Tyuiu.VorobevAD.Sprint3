using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task2.V1.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task2V1

    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int i = startValue;
            double S = 0;
            do
            {
                S += Math.Sin(i) * Math.Pow(1 / 2, 2);
            }
            while (i <= stopValue);

            return S;

            throw new NotImplementedException();
        }
    }
}
