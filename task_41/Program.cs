/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите числа через пробел: ");
string[] numbers = Console.ReadLine().Split();
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (Convert.ToInt32(numbers[i]) > 0) count++;
}

Console.WriteLine($"Вы ввели {count} числа,значение которых больше 0.");