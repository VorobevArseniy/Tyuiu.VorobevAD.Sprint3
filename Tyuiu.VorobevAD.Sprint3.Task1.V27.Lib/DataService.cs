using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task1.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double P = startValue;
            while (startValue <= stopValue)
            {
                P *= Math.Pow(1 / (Math.Pow(value, startValue)), 3);
                startValue++;
            }
            return P;
            throw new NotImplementedException();
        }
    }
}
