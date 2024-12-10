using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO;
using System.Globalization;

namespace Tyuiu.VaganovMA.Sprint5.Task4.V2.Lib;

public class DataService : ISprint5Task4V2
{
    public double LoadFromDataFile(string path)
    {
        string strX = File.ReadAllText(path);
        double x = double.Parse(strX, CultureInfo.InvariantCulture);
        double res = (Math.Cos(x) + 3 * x) / (0.25 * x) + 4 - 2.1 * x;
        res = Math.Round(res, 3);
        return res;
    }
}

//string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt"); 
//double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); 
//z =Math.Round(z, 3); 
//File.WriteAllText(path, Convert.ToString(z)); 
//return path; 
