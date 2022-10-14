// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

 Console.WriteLine("В этой программе вы можете ввести 3 числа и узнать, какое из них максимальное");

 Console.Write("\nВведите первое число: \t");
 int number1 = int.Parse(Console.ReadLine());
 
 Console.Write("\nВведите второе число: \t");
 int number2 = int.Parse(Console.ReadLine());
 
 Console.Write("\nВведите третье число: \t");
 int number3 = int.Parse(Console.ReadLine());

 int max = number1;

 if (number2 > max)
 {
    if (number3 > number2)
    {
        max = number3;
    }
    else
    {
        max = number2;
    }
 }
 else
 {
    if (number3 > max)
    {
        max = number3;
    }
 }

 Console.Write($"\nМаксимальное число - {max}\t");