using Tyuiu.VaganovMA.Sprint5.Task0.V24.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\Users\Ignis\source\repos\Tyuiu.VaganovMA.Sprint5\Tyuiu.VaganovMA.Sprint5.Task0.V24.Lib\bin\Debug\net8.0\OutPutFileTask0.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExit = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(true, fileExit);         
   } 
} 
    
