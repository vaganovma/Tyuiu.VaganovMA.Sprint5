using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO; 
 
namespace Tyuiu.VaganovMA.Sprint5.Task7.V14.Lib;

public class DataService : ISprint5Task7V14
{
    public string LoadDataAndSave(string path)
    {
        double res = 0;
        int count = 0;
        string data = File.ReadAllText(path);
        string[] strings = data.Split(' ');
        string newRes = "";
           
        foreach (string s in strings)
        {
            if (s.All(s=> !char.IsUpper(s)))   //(char.IsDigit(s)) 
            { 
                newRes += s.Replace('t', 'T')
                .Replace('i', 'I')
                .Replace('f', 'F')
                .Replace('a', 'A')
                .Replace('e', 'E')
                .Replace('r', 'R')
                .Replace('s', 'S');               
            }
        }
        Console.WriteLine(newRes);
        return newRes;

    }
}