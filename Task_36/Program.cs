/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void Randomizer(int[] Massive) // создаём функцию для заполнения случайными 
// числами нового массива 
{
    for (int i = 0; i < Massive.Length; i++)
    {
       Massive[i] = new Random().Next(-10, 100);
       System.Console.Write(Massive[i] + " ");
    }
}
void View(int[] Massive) // создаём функцию для определения элементов, стоящих на
// нечетных позициях в массиве 
{
    int result = 0; // для хранения результатов для начала равное нулю
    for (int i = 0; i < Massive.Length; i++)
    {
        if (i % 2 != 0) // если остаток от деления элементов массива на 2 НЕ равен 0, то  
        
            {
            result += Massive[i]; // просуммируй такие элементы
            }
            
    }
    System.Console.WriteLine();
    System.Console.Write($"Cумма элементов, стоящих на нечётных позициях равна {result} "); 
    System.Console.WriteLine();
    
}

int[] Massive = new int[20];
Randomizer(Massive);
View(Massive);

