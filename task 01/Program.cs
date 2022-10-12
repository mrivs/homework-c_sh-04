/*/

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Применять Math.Pow нельзя!
3, 5 -> 243 (3⁵)

2, 4 -> 16

/*/

Console.WriteLine("Введите число А");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

if (B < 0) Console.WriteLine("Неверно заданно В");
else
    Console.WriteLine(Exponentiation(A, B));



double Exponentiation(double A, int B)
{
    double res = 1;

    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}