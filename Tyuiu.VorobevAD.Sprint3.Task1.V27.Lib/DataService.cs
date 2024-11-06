using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task1.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double P = 1;
            while (startValue <= stopValue)
            {
                double term = Math.Pow(1.0 / (startValue * value), 3);
                P *= term;
                startValue++;
            }
            return P;
            throw new NotImplementedException();
        }
    }
}
