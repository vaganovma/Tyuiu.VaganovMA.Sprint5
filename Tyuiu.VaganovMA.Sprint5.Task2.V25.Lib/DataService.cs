using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VaganovMA.Sprint5.Task2.V25.Lib;

public class DataService : ISprint5Task2V25
{
    public string SaveToFileTextData(int[,] matrix)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
        //double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); 
        // z =Math.Round(z, 3); 
        //File.WriteAllText(path, Convert.ToString(z));
        // return path;
        FileInfo fileInfo = new FileInfo(path);
        bool fileExit = fileInfo.Exists;

        if (fileExit)
        {
            File.Delete(path);
        }

        int rows = matrix.GetUpperBound(0) + 1;//кол строк
        int stolb = matrix.Length / rows;      //кол столбцов
        //int minzn = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (j != stolb - 1)
                {
                    str += matrix[i, j] + ";";
                }
                else
                {
                    str += matrix[i, j];
                }
            }

            if (i != rows - 1)
            {
                File.AppendAllText(path, str + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(path, str);
            }

            str = "";
        }
        return path;
    }
}


