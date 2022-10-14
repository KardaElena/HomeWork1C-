// See Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("В этой программе вы сможете получить все четные числа от 1 до вашего числа :) Попробуйте прямо сейчас!");

Console.Write("\nВведите ваше число (чур не менее 2): ");

int number = int.Parse(Console.ReadLine());

int even = 2;

if (number < even)
{
    Console.WriteLine($"\n Вы ввели число {number}, которое меньше 2. Невозможно составить промежуток");
}

else
{  
    while (even <= number)
    {
        if (even == 2)
        {
            Console.Write($"\n2");
        }
        else
        {
        Console.Write($", {even}");
        }
    even = even+2;
    } 
    Console.WriteLine(".");
    Console.WriteLine ($"\nЭто все числа от 1 до {number}");
    Console.WriteLine ("\n");
}