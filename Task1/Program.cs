// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("В этой программе вы сможете узнать, какое число из двух большее, а какое - меньшее\t");
Console.Write("\nВведите первое число: ");
int Number1 = int.Parse(Console.ReadLine());

Console.Write("\nВведите второе число: ");
int Number2 = int.Parse(Console.ReadLine());

int max = Number1;

if (max > Number2)
{
    Console.Write($"\nПервое число {Number1} - большее, а второе число {Number2} - меньшее\t");
}

else if (max == Number2)
{
    Console.WriteLine("\nЧисла равны\t");
}

else
{
    Console.WriteLine($"\nПервое число {Number1} - меньшее, а второе число {Number2} - большее\t");
}
