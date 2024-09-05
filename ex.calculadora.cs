using System;
public class Calculadora
{
  public static void Main(string[] args)
  {
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escolha uma operação:\n1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão");
    int res = Convert.ToInt32(Console.ReadLine());
    if(res == 1)
    {
      Console.WriteLine(num1+num2);
    }
    else if(res == 2)
    {
      Console.WriteLine(num1-num2);
    }
    else if(res == 3)
    {
      Console.WriteLine(num1*num2);
    }
    else if(res == 4)
    {
      Console.WriteLine(num1/num2);
    }
    else 
    {
      Console.WriteLine("Operação inválida");
    }
  }
}