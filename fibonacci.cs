using System;

class MainClass {
  public static void Main (string[] args) {
		int result  = Fibonacci(7);
		Console.WriteLine(result);
  }
  
  static int Fibonacci(int x){
    if (x<=1)
      return 1;
    else
      return Fibonacci(x-1) + Fibonacci(x-2);
  }
}