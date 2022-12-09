/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetNumber(string message)

{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

                if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int multiDigitNumber = GetNumber($"Введите число:");
Console.WriteLine($"Для дальнейших вычислений введено с клавиатуры число {multiDigitNumber}");

int GetSumNumber(int number)
{
    int summary = 0; 
     
    while(number > 0)
    {
       summary = summary + number%10;
       number = number/10;
    }
       
    return(summary);
}

int DigSum =  GetSumNumber(multiDigitNumber);
Console.WriteLine($"Разрядность введённого числа {multiDigitNumber} равна {DigSum}");