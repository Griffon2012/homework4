//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.

int MyPow(int basePOW, int expPOW)
{
    int result = 1;
    for (int i = 1; i <= expPOW; i++)
    {
        result *= basePOW;
    }

    return result;
}

Console.Write("Введите основание степени: ");
int basePOW = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int expPOW = Convert.ToInt32(Console.ReadLine());

if (expPOW < 0)
{
    Console.WriteLine("Показатель степени должен быть натуральным числом");
}
else
{
    Console.WriteLine($"{MyPow(basePOW, expPOW)}");
}


