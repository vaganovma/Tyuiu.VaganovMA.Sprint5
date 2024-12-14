using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO;
using System.Globalization;

namespace Tyuiu.VaganovMA.Sprint5.Task6.V19.Lib;

public class DataService : ISprint5Task6V19
{
    public int LoadFromDataFile(string path)
    {
        double res = 0;
        int count = 0;
        string data = File.ReadAllText(path);
        string[] strings = data.Split(' ');
        string newRes = "";

        //var number = new List<double>();
        //foreach (string s in strings)
        //{
        //    double nunber = double.Parse(s, CultureInfo.InvariantCulture);
        //    number.Add(nunber);
        //}

        foreach (string s in strings)
        { 
           if (s.All(char.IsDigit))   //(char.IsDigit(s)) «десь вы пытаетесь проверить каждую строку s на наличие цифр. ќднако, метод char.IsDigit ожидает символ, а не строку. Ёто приведЄт к ошибке компил€ ¬место этого, вам следует использовать s.All(char.IsDigit) после преобразовани€ строки в символы или использовать регул€рные выражени€ дл€ выделени€ чисел.
            {
                newRes = newRes + s + " ";
                if (s.Length == 2) { count++; }
            }    
        }               
        return count;
    }
}


