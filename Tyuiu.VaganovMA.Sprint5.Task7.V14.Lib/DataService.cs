using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint5.Task7.V14.Lib;

public class DataService : ISprint5Task7V14
{
    public string LoadDataAndSave(string path)
    {
        //double res = 0;
        //int count = 0;        
        //string data = File.ReadAllText(path);
        //string[] strings = data.Split(' ');
        //string newRes = "";

        string PathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V14.txt");
        FileInfo fileInfo = new FileInfo(PathSaveFile);
        bool fileExists = fileInfo.Exists;
        if (fileExists) { File.Delete(PathSaveFile); }
        string str = File.ReadAllText(path);
        string newRes = "";

        //foreach (char s in str) //strings)
        //{
        //    if (s.All(s => !char.IsUpper(s)))   //(char.IsDigit(s)) 
        //    { 
        //        newRes += s.Replace('t', 'T')
        //            .Replace('i', 'I')
        //            .Replace('f', 'F')
        //            .Replace('a', 'A')
        //            .Replace('e', 'E')
        //            .Replace('r', 'R')
        //            .Replace('s', 'S');               
        //    }
        //}
        foreach (char s in str)
        {
            // Заменяем строчные буквы на заглавные
            switch (s)
            {
                case 't': newRes += 'T'; break;
                case 'i': newRes += 'I'; break;
                case 'f': newRes += 'F'; break;
                case 'a': newRes += 'A'; break;
                case 'e': newRes += 'E'; break;
                case 'r': newRes += 'R'; break;
                case 's': newRes += 'S'; break;
                default:
                    // Если символ не строчный, добавляем его как есть
                    newRes += char.ToUpper(s); // Преобразуем любой другой символ в заглавный
                    break;
            }
        }

        //   TIg F AA TERS
        //  A StRiNg Of CaPITaL LEtTers
        File.AppendAllText(PathSaveFile, newRes);
        Console.WriteLine(newRes);
        return PathSaveFile;

    }
}