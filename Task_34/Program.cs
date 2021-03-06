/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2
 */

void Randomseed(int[] Array) // создаём функцию для заполнения случайными положительными 
// трехзначными числами нового массива 
{
    for (int i = 0; i < Array.Length; i++)
    {
       Array[i] = new Random().Next(100, 1000); // заполним массив рандомными числами от 100 до 999
    }
}
void Spot(int[] Array) // создаём функцию для определения четных
// трехзначных чисел в массиве 
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) // если остаток от деления на 2 равен 0, то выведи 
        // эти четные числа на экран
        System.Console.Write($"{Array[i]} "); // числа выводи на экран через пробел
    }
}

int[] Array = new int[899]; // заполняем массив с 899 количеством элементов
Randomseed(Array);
Spot(Array);
