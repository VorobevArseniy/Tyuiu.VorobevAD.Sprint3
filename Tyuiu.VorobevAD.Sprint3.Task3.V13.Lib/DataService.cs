using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevAD.Sprint3.Task3.V13.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string s = "";
            foreach (char i in value)
            {
                if (i == '5')
                {
                    s += i;
                }
            }

            return ConvertStringToInt(s);

            throw new NotImplementedException();
        }
    }
}
