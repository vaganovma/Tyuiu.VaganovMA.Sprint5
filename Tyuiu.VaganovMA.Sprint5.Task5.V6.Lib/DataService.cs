using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO;
using System.Globalization;

namespace Tyuiu.VaganovMA.Sprint5.Task5.V6.Lib;

public class DataService : ISprint5Task5V6
{
    public double LoadFromDataFile(string path)
    {
        double res = 0;
        double count = 0;
        string data = File.ReadAllText(path);
        string[] strings = data.Split(' ');
       
        var number = new List<double>();
        foreach (string s in strings)
        {
            double nunber = double.Parse(s,CultureInfo.InvariantCulture);
            number.Add(nunber);
        }

        foreach (double nunber in number)
        {
            res += nunber;
            count++;
        }
                                                            //using (StreamReader reader = new StreamReader(path))
                                                            //{
                                                            //    string line;
                                                            //    while ((line = reader.ReadLine()) != null)
                                                            //    {
                                                            //        res += Convert.ToDouble(line);
                                                            //        count++;
                                                            //    }
                                                            //}
        res=res/count;
        return Math.Round(res);
    }
}

//string strX = File.ReadAllText(path);
//        double x = double.Parse(strX, CultureInfo.InvariantCulture);
//        double res = (Math.Cos(x) + 3 * x) / (0.25 * x) + 4 - 2.1 * x;
//        res = Math.Round(res, 3);
//        return res;
//string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask5.txt"); 
//double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); 
//z =Math.Round(z, 3); 
//File.WriteAllText(path, Convert.ToString(z)); 
//return path; 
