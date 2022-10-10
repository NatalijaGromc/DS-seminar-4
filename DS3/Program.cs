// Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array;

int[] CreateArray()
{
int N;
string userEnter;
int[] _array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите элемент номер {i} ");
    userEnter = Console.ReadLine()!;
    N = int.Parse(userEnter);
    _array[i] = N;
}
return _array;
}

array = CreateArray();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.Write("]");