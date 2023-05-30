// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2 -> 2
// 1,-7, -567, 89, 223 -> 3

Console.WriteLine("Введите числа через запятую");
string Temp = Console.ReadLine();
string[] array = Temp.Split(',');
int[] intArray = new int[array.Length];
int count = 0;
for (int i=0; i< array.Length; i++)
{
    intArray[i] = Convert.ToInt32(array[i]);
    if (intArray[i]>0) count++;
}
Console.WriteLine($"{Temp} -> {count}");