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
           if (s.All(char.IsDigit))   //(char.IsDigit(s)) ����� �� ��������� ��������� ������ ������ s �� ������� ����. ������, ����� char.IsDigit ������� ������, � �� ������. ��� ������� � ������ ������� ������ �����, ��� ������� ������������ s.All(char.IsDigit) ����� �������������� ������ � ������� ��� ������������ ���������� ��������� ��� ��������� �����.
            {
                newRes = newRes + s + " ";
                if (s.Length == 2) { count++; }
            }    
        }               
        return count;
    }
}


