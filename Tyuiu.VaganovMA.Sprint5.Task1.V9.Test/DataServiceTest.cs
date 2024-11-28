using Tyuiu.VaganovMA.Sprint5.Task1.V9.Lib; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
     string path = @"C:\Users\Ignis\AppData\Local\Temp\OutPutFileTask1.txt"; 
     FileInfo fileInfo = new FileInfo(path); 
     bool fileExit = fileInfo.Exists; 
     bool wait = true; 
     Assert.AreEqual(true, fileExit); 
   } 
} 
   //не делал!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
