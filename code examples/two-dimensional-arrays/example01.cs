using System;

class MainClass {
  public static void Main (string[] args) {
    string[,] myList = {
      {"red","orange"},
      {"yellow","green"}
    };
    
    Console.WriteLine(myList[1,0][4]);
    Console.WriteLine(myList[0,1][0]);
  }
}
