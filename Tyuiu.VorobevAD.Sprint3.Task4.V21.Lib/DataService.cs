using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task4.V21.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task4V21
{
	public double Calculate(int startValue, int stopValue)
	{
		double num = 1;

		for (int x = startValue; x <= stopValue; x++)
		{
			if (x == 0) continue;

			double y = (Math.Cos(x) - x) / x;
			num *= y;
		}
		return Math.Round(num, 3);
		throw new NotImplementedException();
	}
}
