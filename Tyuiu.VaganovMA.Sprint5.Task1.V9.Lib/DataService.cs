using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.VaganovMA.Sprint5.Task1.V9.Lib;

public class DataService : ISprint5Task1V9
{
    public string SaveToFileTextData(int startValue, int stopValue)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
        FileInfo fileInfo = new FileInfo(path);
        bool fileExit = fileInfo.Exists;
        if (fileExit) { File.Delete(path); }

        double y;
        string strY;
            for (int x= startValue; x <= stopValue; x++)
        {
            y = Math.Sin(x)+Math.Cos(2*x)/2-1.5*x;
            y = Math.Round(y, 3);
             
            strY = Convert.ToString(y);
            if (x !=  stopValue)
            {
                File.AppendAllText(path, strY + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(path, strY);
            }
        }

        //double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); 
        //z =Math.Round(z, 3); 
        //File.WriteAllText(path, Convert.ToString(z)); 
        return path; 
        
    }
}


