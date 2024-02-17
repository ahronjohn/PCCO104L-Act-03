using System;

class Program {
  public static void Main (string[] args) {
    string input = "";
    
    while (input != "zaijian")
    {
      Console.WriteLine("Ni jiao shenme mingzi?");
      input = Console.ReadLine();
      Console.WriteLine("Wo jiao Gab, " + input + ",");
    }
      Console.WriteLine("jian");
  }
}