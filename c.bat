@echo off

set prefix=Tyuiu

set fio=Ваганов. М. А.
set full_fio=Ваганов Михаил Алексеевич 
set group=ИИПб-24-2
set name=VaganovMA

set sprint=5
set task=1
set variant=9

set template=%prefix%.%name%.Sprint%sprint%
set filename_template=%template%.Task%task%.V%variant%

set console_path=%filename_template%
set classlib_path=%filename_template%.Lib
set mstest_path=%filename_template%.Test

:: Создаём проекты
:: Консольное приложение
dotnet new console --use-program-main -o %console_path%
:: Библиотека
dotnet new classlib -o %classlib_path%
:: Тестирование
dotnet new mstest -o %mstest_path%

set classlib_csproj=%classlib_path%\%classlib_path%.csproj
:: Дурацким способом подключаем dll к библиотеке классов
echo ^<Project Sdk="Microsoft.NET.Sdk"^> > %classlib_csproj%
echo. >> %classlib_csproj%
echo   ^<PropertyGroup^> >> %classlib_csproj%
echo     ^<TargetFramework^>net8.0^</TargetFramework^> >> %classlib_csproj%
echo     ^<ImplicitUsings^>enable^</ImplicitUsings^> >> %classlib_csproj%
echo     ^<Nullable^>enable^</Nullable^> >> %classlib_csproj%
echo   ^</PropertyGroup^> >> %classlib_csproj%
echo. >> %classlib_csproj%
echo   ^<ItemGroup^> >> %classlib_csproj%
echo     ^<Reference Include="tyuiu.cources.programming.interfaces"^> >> %classlib_csproj%
echo       ^<HintPath^>..\tyuiu.cources.programming.interfaces.dll^</HintPath^> >> %classlib_csproj%
echo     ^</Reference^> >> %classlib_csproj%
echo   ^</ItemGroup^> >> %classlib_csproj%
echo. >> %classlib_csproj%
echo ^</Project^> >> %classlib_csproj%

:: Создаём шаблон для консольного приложения
set console_class=%console_path%\Program.cs
echo namespace Tyuiu.%name%.Sprint%sprint%.Task%task%.V%variant%; >> %console_class%
echo. >> %console_class%
echo using %classlib_path%; > %console_class%
echo. >> %console_class%
echo class Program >> %console_class%
echo { >> %console_class%
echo     static void Main(string[] args) >> %console_class%
echo     { >> %console_class%
echo         DataService ds = new DataService();>> %console_class%
echo         Console.Title = "Спринт #%sprint% | Выполнил: %fio% | %group%"; >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* Спринт #%sprint%                                                            *"); >> %console_class%
echo         Console.WriteLine("* Тема:                                                                *"); >> %console_class%
echo         Console.WriteLine("* Задание #%task%                                                           *"); >> %console_class%
echo         Console.WriteLine("* Вариант #%variant%                                                          *"); >> %console_class%
echo         Console.WriteLine("* Выполнил: %full_fio% | %group%                                                           *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* УСЛОВИЕ:                                                             *"); >> %console_class%
echo         Console.WriteLine("*                                                                      *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine("Введите переменную X:"); >> %console_class%
echo         double x = Convert.ToDouble(Console.ReadLine()); >> %console_class%
echo         Console.WriteLine("Введите переменную Y:"); >> %console_class%
echo         int y = int.Parse(Console.ReadLine()!); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine() >> %console_class%
echo         string res = ds.SaveToFileTextData(x); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine($"Файл "+res); >> %console_class%
echo         Console.WriteLine($"Создан"); >> %console_class%
echo         Console.ReadKey(); >> %console_class%
echo     } >> %console_class%
echo } >> %console_class%

:: Создаём шаблон для библиотеки классов
del %classlib_path%\Class1.cs
set classlib_class=%classlib_path%\DataService.cs
echo namespace %classlib_class%; >> %classlib_class%
echo. >> %classlib_class%
echo using System.IO; >> %classlib_class%
echo using tyuiu.cources.programming.interfaces.Sprint%sprint%; > %classlib_class%
echo. >> %classlib_class%
echo namespace %classlib_path%; >> %classlib_class%
echo. >> %classlib_class%
echo public class DataService //: ISprint%sprint%Task%task%V%variant% >> %classlib_class%
echo { >> %classlib_class%
echo } >> %classlib_class%
echo. >> %classlib_class%
echo string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask%task%.txt"); >> %classlib_class%
echo double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)); >> %classlib_class%
echo z =Math.Round(z, 3); >> %classlib_class%
echo File.WriteAllText(path, Convert.ToString(z)); >> %classlib_class%
echo return path; >> %classlib_class%

:: Создаём шаблон для тестов
del %mstest_path%\UnitTest1.cs
set mstest_class=%mstest_path%\DataServiceTest.cs
echo namespace %mstest_path%; >> %mstest_class%
echo. >> %mstest_class%
echo using %classlib_path%; > %mstest_class%
echo. >> %mstest_class%
echo [TestClass] >> %mstest_class%
echo public class DataServiceTest >> %mstest_class%
echo { >> %mstest_class%
echo    [TestMethod] >> %mstest_class%
echo    public void ValidExpression()  >> %mstest_class%
echo    { >> %mstest_class%
echo        string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask%task%.txt"; >> %mstest_class%
echo        FileInfo fileInfo = new FileInfo(path); >> %mstest_class%
echo        bool fileExit = fileInfo.Exists; >> %mstest_class%
echo        bool wait = true; >> %mstest_class%
echo        Assert.AreEqual(true, fileExit); >> %mstest_class%
echo    } >> %mstest_class%
echo } >> %mstest_class%
echo    //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! >> %mstest_class%

:: Добавляем в решение
dotnet sln %template%.sln add %console_path%\%console_path%.csproj --solution-folder Task%task%
dotnet sln %template%.sln add %classlib_csproj% --solution-folder Task%task%
dotnet sln %template%.sln add %mstest_path%\%mstest_path%.csproj --solution-folder Task%task%

:: Добавляем ссылки на библиотеку
dotnet add %console_path%\%console_path%.csproj reference %classlib_csproj%
dotnet add %mstest_path%\%mstest_path%.csproj reference %classlib_csproj%