using Tyuiu.VaganovMA.Sprint5.Task1.V9.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #9                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("startValue =" + startValue);        
        Console.WriteLine("stopValue =" + stopValue);        
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
     
        string res = ds.SaveToFileTextData(startValue, stopValue); 
 
        Console.WriteLine($"Файл "+res); 
        Console.WriteLine($"Создан"); 
        Console.ReadKey(); 
    } 
} 
