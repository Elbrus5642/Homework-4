/* Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
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

int numberA = GetNumber("Введите число А, которе будет возводиться в степень: ");
Console.WriteLine($"Основание степени {numberA}"); 
int numberB =  GetNumber("Введите число В, показатель степени числа А: ");
Console.WriteLine($"Показатель степени {numberB}");
int GetStepen(int num1, int num2)
{ 
    int stePen = 1;
    int index = 1;
    while(index <= num2)
    {
        stePen = stePen * num1;
        index++;
    }
    return(stePen);
}

Console.WriteLine($"Число {numberA} в степени {numberB} равно {GetStepen(numberA,numberB)}");