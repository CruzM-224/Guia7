using System;

class MainClass {
  public static void Main (string[] args) {
    Double x, y;
    string eleccion = "";

    do{
      Console.WriteLine("Escriba un x");
      x = Double.Parse(Console.ReadLine());
      Console.Clear();

      Console.WriteLine("a) Seno de x.");
      Console.WriteLine("b) Coseno de x.");
      Console.WriteLine("c) Tangente de x.");
      Console.WriteLine("d) Raiz cuadrada de x.");
      Console.WriteLine("e) Potencia de Yx.");
      Console.WriteLine("f) Verificar si un número es par o impar.");
      Console.WriteLine("g) Salir del programa.");
      eleccion = Console.ReadLine();
      
      switch(eleccion){
        case "a":
            Console.Clear();
            Console.WriteLine(Math.Sin(x));
            break;
        case "b":
            Console.Clear();
            Console.WriteLine(Math.Cos(x));
            break;
        case "c":
            Console.Clear();
            Console.WriteLine(Math.Tan(x));
            break;
        case "d":
            Console.Clear();
            Console.WriteLine(Math.Sqrt(x));
            break;
        case "e":
            Console.Clear();
            Console.WriteLine("Escriba un y");
            y = Double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(y, x));
            break;
        case "f":
            Console.Clear();
            if(x%2 == 0){
              Console.WriteLine("Es par");
            }else{
              Console.WriteLine("Es impar");
            }
            break;
        case "g":
            Environment.Exit(1);
            break;
        default:
            break;
      }
    }while(true);
  }
}