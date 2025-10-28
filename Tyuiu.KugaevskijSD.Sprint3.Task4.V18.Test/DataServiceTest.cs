using Tyuiu.KugaevskijSD.Sprint3.Task4.V18.Lib;
namespace Tyuiu.KugaevskijSD.Sprint3.Task4.V18.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        double wait = 2.993;
        int startValue = -5;
        int stopValue = 5;
        var res = ds.Calculate(startValue, stopValue);
        Assert.AreEqual(res, wait);
    }
}