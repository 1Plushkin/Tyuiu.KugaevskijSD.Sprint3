namespace Tyuiu.KugaevskijSD.Sprint3.Task0.V1.Test;
using Tyuiu.KugaevskijSD.Sprint3.Task0.V1.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();

        int value = 4;
        int startValue = 1;
        int stopValue = 10;

        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 890;
        Assert.AreEqual(wait, res);
    }
}