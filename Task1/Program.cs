// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());

int max = Number1;

if (max > Number2)
{
    Console.Write($"Первое число {Number1} - большее, а второе число {Number2} - меньшее");
}

else if (max == Number2)
{
    Console.WriteLine("Числа равны");
}

else
{
    Console.WriteLine($"Первое число {Number1} - меньшее, а второе число {Number2} - большее");
}
