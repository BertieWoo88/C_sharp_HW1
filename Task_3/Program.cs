//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int chislo = 2; 
while(chislo<=N) 
{
    Console.Write(" " + chislo);
    chislo+=2; 
}