using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KozyrevaIV.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            double Pi = 3.14;
            double res = value * (Pi / 180);
            return Math.Round(res, 3);
        }
    }
}
