﻿using tyuiu.cources.programming.interfaces.Sprint3;

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
                S += Math.Sin(i) * 1 / 4;
                i++;
            }
            while (i <= stopValue);

            return Math.Round(S, 3);

            throw new NotImplementedException();
        }
    }
}
