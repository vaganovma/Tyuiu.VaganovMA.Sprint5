using Tyuiu.VaganovMA.Sprint5.Task0.V24.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidSaveToFileTextData()  
   {
        string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask0.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExit = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(true, fileExit);         
   } 
} 
     
