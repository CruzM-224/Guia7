using System;

class MainClass {
  public static void Main (string[] args) {
    int numero, cont = 0;
    Console.WriteLine ("Escriba un numero del 1 al 15");
    numero = int.Parse(Console.ReadLine());
    if(numero < 1 || numero > 15){
      Environment.Exit(1);
    }
    while(cont < numero){
      Console.WriteLine("*");
      cont++;
    }
  }
}