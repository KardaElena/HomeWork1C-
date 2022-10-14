// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("В этой программе вы сможете определить, является ли число четным.\t");

Console.Write("\nВведите ваше число: ");

int number = int.Parse(Console.ReadLine());

int rem = number%2;

if (rem == 0)
{
    Console.WriteLine("\nЭто число четное\t");
}
else
{
    Console.WriteLine("\nЭто число нечетное");
}


