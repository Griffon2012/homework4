// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Для решения задания использование цикла for является обязательным условием

int GetSumNumberChar(int number)
{
    string numberString = Convert.ToString(Math.Abs(number));
    int sum = 0;

    for (int i = 0; i < numberString.Length; i++)
    {
        sum += Convert.ToInt32(numberString[i].ToString());
    }

    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{GetSumNumberChar(number)}");

