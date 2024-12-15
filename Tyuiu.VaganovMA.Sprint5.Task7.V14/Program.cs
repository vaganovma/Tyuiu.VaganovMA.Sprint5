using Tyuiu.VaganovMA.Sprint5.Task7.V14.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #14                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                             *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
  
        string path = $@"C:\DataSprint5\InPutDataFileTask7V14.txt"; 
        Console.WriteLine("данные находятся в файле: " + path); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine();
        string res = $@"C:\DataSprint5\InPutDataFileTask7V14.txt";
        res = ds.LoadDataAndSave(path); 

        Console.WriteLine($"A StRiNg Of CaPITaL LEtTers");
        Console.WriteLine(res);
        
        //Console.WriteLine($"Создан"); A StRiNg Of CaPITaL LEtTers
        Console.ReadKey(); 
    } 
} 
