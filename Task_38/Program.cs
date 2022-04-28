/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

double[] Mass = new double[10]; // заполняем массив с 899 количеством элементов
for (int i = 0; i < Mass.Length; i++)
{
Mass[i] = new Random().NextDouble(); // заполним массив рандомными числами от -10 до 99
System.Console.Write($" {Mass[i]}, "); // выведи на экран все числа массива
}
double Max(double[] Mass) // создаем функцию поиска максимального числа в массиве
{
    int index = 0;
    double max = Mass[index]; // объявляем переменную max которая равна какому-то
    // первому числу массива 
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] >= max) // если какое-то число массива больше максимального числа
        max = Mass[i]; // то такое число становится максимальным
    }
    System.Console.WriteLine($"Максимальный элемент массива равен {Math.Round(max, 3)} "); 
    return max;
}
double Min(double[] Mass) // создаем функцию поиска минимального числа в массиве
{
    int index = 0;
    double min = Mass[index]; // объявляем переменную min которая равна какому-то
    // первому числу массива 
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] <= min) // если какое-то число массива меньше минимального числа
        min = Mass[i]; // то такое число становится максимальным
    }
    System.Console.Write($"Минимальный элемент массива равен {Math.Round(min, 3)} "); 
    System.Console.WriteLine();
    return min;
}
System.Console.Write($"Разница между максимальным и минимальным значением = {Max(Mass) - Min(Mass)}"); 
System.Console.WriteLine();