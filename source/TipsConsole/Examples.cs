namespace TipsConsole {
  internal class Examples {
    public void GetFileContent() {
      var currentDir = Environment.CurrentDirectory; // Get a cross platform full path
      var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "Testando.txt");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("-----");
      Console.WriteLine(filePath);
      Console.WriteLine("-----");
      Console.ForegroundColor = ConsoleColor.Cyan;

      string[] lines = System.IO.File.ReadAllLines(filePath);
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("-----");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
    }

  
 
  }

}
