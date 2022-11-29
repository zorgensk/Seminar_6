// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] ConvertStrInInt(string? s) // Конвертация string в int[]
{
int [] nums = s.Split(' ','.',',').Select(Int32.Parse).ToArray();
return nums;
}

int ReturnPositiveValue(int[] num) // Решение задачи.
{
    int value = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if(num[i] > 0) value++;
    }
    return value;
}
Console.WriteLine("Введите числа");
string? s = Console.ReadLine();

Console.WriteLine($"Ответ: {ReturnPositiveValue(ConvertStrInInt(s))}");




