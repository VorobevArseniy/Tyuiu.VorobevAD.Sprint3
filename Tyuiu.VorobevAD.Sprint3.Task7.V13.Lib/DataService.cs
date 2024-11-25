namespace Tyuiu.VorobevAD.Sprint3.Task7.V13.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task7V13
{
	public double[] GetMassFunction(int startValue, int stopValue)
	{
		double[] results = new double[stopValue - startValue + 1];
		int index = 0;

		for (int x = startValue; x <= stopValue; x++)
		{
			double denominator = Math.Cos(x) + 1;
			double fx;

			if (Math.Abs(denominator) < 1e-10) // Проверка деления на ноль
			{
				fx = 0;
			}
			else
			{
				fx = 3 * x + 2 - (2 * x - x) / denominator;
			}

			fx = Math.Round(fx, 2); // Округление до двух знаков
			results[index++] = fx;


		}
		return results;
		throw new NotImplementedException();
	}
}