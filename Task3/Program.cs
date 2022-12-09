/* Напишите программу, 
которая задаёт массив из 
8 элементов и выводит их на экран
*/
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int GetNumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число");
        }
    }

    return result;

}

int[] GetArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetNumber($"Введите {i + 1}-е число:");
    }

    return arr;
}

int[] array = GetArray();

Console.Write($"Первые пять элементов массива [{array[0]}, "
+ $"{array[1]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}]");

Console.WriteLine();

Console.Write($"Оставшиеся три элемента массива [{array[5]}, "
+ $"{array[6]}, {array[7]}]");

