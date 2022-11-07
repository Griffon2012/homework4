//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.

string[] getFilledArray()
{
    string[] array = new string[8];
    string? myString = "";

    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"Введите {i + 1} элемент: ");
        myString = Console.ReadLine();
        if (myString is null)
        {
            array[i] = "";
        }
        else
        {
            array[i] = myString;
        }
    }

    return array;
}

string[] array = getFilledArray();
Console.WriteLine($"[{String.Join(", ", array)}]");