using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VaganovMA.Sprint5.Task3.V11.Lib;
using System.IO;
using System.Text;

public class DataService : ISprint5Task3V11
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bln"); 
        double z = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2); 
        z =Math.Round(z, 3); 

        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
        {
            writer.Write(BitConverter.GetBytes(z));
        }

        //File.WriteAllText(path, Convert.ToString(z)); 
        return path; 
    }
}


