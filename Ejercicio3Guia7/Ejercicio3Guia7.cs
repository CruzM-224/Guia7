using System;

class MainClass {
  public static void Main (string[] args) {
    int num1, num2, cont = 0;
    Console.WriteLine ("Escriba dos numeros");
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());

    if(num1 > num2){
      cont = num1;
      while(cont >= num2){
        if(cont%2 == 0){
          Console.WriteLine(cont);
        }
        cont--;
      }
    }else{
      cont = num1;
      while(cont <= num2){
        if(cont%2 == 0){
          Console.WriteLine(cont);
        }
        cont++;
      }
    }
  }
}