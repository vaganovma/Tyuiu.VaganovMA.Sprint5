using Tyuiu.VaganovMA.Sprint5.Task0.V24.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #24                                                          *");       
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
        
        int x = 3;
        Console.WriteLine($"X =  {x}");

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        string res = ds.SaveToFileTextData(x);

        Console.WriteLine($"Файл "+res);
        Console.WriteLine($"Создан");
        Console.ReadKey(); 
    } 
} 
