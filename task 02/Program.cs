
/*/

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

/*/


int N = PrintAndGetValue("Введите число");
Console.WriteLine(Summ(N));


int Summ(int N)
{
    int res = 0;
    for (int i = 1; i <= LengthInt(N); i++)
    {
        res = res + NumberR(N, i);
    }
    return res;
}

int NumberR(int A, int n) // находит n-ю цифру числа А (справа налево)
{

    // A/10^(n-1) % 10 

    int r = (int)(A / (Math.Pow(10, n - 1)) % 10);
    return Math.Abs(r);
}

int LengthInt(int A) // находит длинну числа А 
{
    int l = 1;
    A = Math.Abs(A);

    while (A > 9)
    {
        A = A / 10;
        l++;
    }
    return l;
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}
