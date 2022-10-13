
/*/
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
/*/

int N = PrintAndGetValue("Введите длинну массива");
int min = PrintAndGetValue("Введите min");
int max = PrintAndGetValue("Введите max");

if (N > 0 && max >= min)
{
    int[] arr = CreateArray(N, min, max);
    Console.WriteLine(PrintArray(arr));
}
else {
    Console.WriteLine("Неверные входные значения");
}

int[] CreateArray(int N, int min, int max)  // создаем массив длинной N и значениями в диапазоне [min, max]
{
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

string PrintArray(int[] array) // пишем массив в строку
{
    string str = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) str = str + array[i] + ", ";
        else str = str + array[i] + "]";
    }
    return str;
}


int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}