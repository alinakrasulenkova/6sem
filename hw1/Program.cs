// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Array.ConvertAll() метод преобразования массива одного типа в другой тип.
//  Мы можем использовать его следующим образом для преобразования
//   массива строк в массив целых чисел


Console.Write("Введите числа с пробелом между ними: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int count = 0;
 
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine("Колличество чисел больше нуля = "+count);