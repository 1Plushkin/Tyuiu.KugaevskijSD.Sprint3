using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KugaevskijSD.Sprint3.Task3.V10.Lib;

public class DataService : ISprint3Task3V10
{
    public string DeleteCharInString(string value, char item)
    {

        foreach (char i in value)
        {
            if (i == item)
            {
                value = value.Replace(item.ToString(), "");
            }
        }
        return value;
    }
}