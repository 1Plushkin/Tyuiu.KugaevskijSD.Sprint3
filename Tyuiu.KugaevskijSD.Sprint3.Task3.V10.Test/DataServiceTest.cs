using Tyuiu.KugaevskijSD.Sprint3.Task3.V10.Lib;
namespace Tyuiu.KugaevskijSD.Sprint3.Task3.V10.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidDeleteCharInString()
    {
        DataService ds = new DataService();
        string value = "gdfppf vfppt p";
        char item = 'p';
        string res = ds.DeleteCharInString(value, item);
        Assert.AreEqual("gdff vft ", res);
    }
}