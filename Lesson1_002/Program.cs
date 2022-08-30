// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое
// число квадратом второго.

Console.WriteLine("введи число 1");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("введи число 2");
int number2=int.Parse(Console.ReadLine());

 if (number1==number2*number2)
 {
     Console.WriteLine("yes");
 }
  else
   {
     Console.WriteLine("no"); 
   } 