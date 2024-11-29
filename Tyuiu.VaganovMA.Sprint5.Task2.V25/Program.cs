using Tyuiu.VaganovMA.Sprint5.Task2.V25.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #25                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        int rows;
        Console.WriteLine("кол строк");
        rows = Convert.ToInt32(Console.ReadLine());
        int columns;
        Console.WriteLine("кол столбцов");
        columns = Convert.ToInt32(Console.ReadLine());


        int[,] mtrx = new int[rows, columns];
        Console.WriteLine("************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Введите значение\t" + i + j + "\tЭлемента массива");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} ");
            }
            Console.WriteLine("\r");
        }
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine();
        string res = ds.SaveToFileTextData(mtrx); 
 
        Console.WriteLine($"Файл "+res); 
        Console.WriteLine($"Создан"); 
        Console.ReadKey(); 
    } 
} 
