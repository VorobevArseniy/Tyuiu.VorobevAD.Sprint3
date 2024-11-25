using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task6.V23.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task6V23
{
	public int GetSumTheDivisors(int startValue, int stopValue)
	{
		int k = 0;
		for (int i = startValue; i <= stopValue; ++i)
		{
			for (int j = 1; j < 11; ++j)
			{
				if (i % j == 0)
				{
					k++;
				}
			}
		}
		return k;
		throw new NotImplementedException();
	}
}
