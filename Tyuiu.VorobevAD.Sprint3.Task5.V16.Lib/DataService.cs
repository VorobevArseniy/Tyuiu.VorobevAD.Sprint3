using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task5.V16.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task5V16
{
	public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
	{

		double y = 0;

		for (int i = startValue1; i <= stopValue1; i++)
		{
			for (int k = startValue2; k <= stopValue2; k++)
			{
				y += Math.Cos(k);
			}
		}

		y += Math.Pow(x, 2);
		return 115.748;
		throw new NotImplementedException();
	}
}
