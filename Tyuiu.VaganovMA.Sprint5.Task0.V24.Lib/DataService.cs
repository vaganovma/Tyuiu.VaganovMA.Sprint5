using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.VaganovMA.Sprint5.Task0.V24.Lib;
using System.IO;
public class DataService : ISprint5Task0V24
{
    public string SaveToFileTextData(int x)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
        double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));
        z =Math.Round(z);
        File.WriteAllText(path, Convert.ToString(z));
        return path;
    }
} 
