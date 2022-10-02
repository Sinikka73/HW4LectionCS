// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int sumOfRangesInNumber(int userNumber)
{
    int result = 0;
    userNumber = Math.Abs(userNumber);
    
        while (userNumber > 0)
        {
            result = result + userNumber%10;
            userNumber = userNumber / 10;
        }

    return result;
}

Console.Write("Введите любое целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sum = sumOfRangesInNumber(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} равна  {sum}"); 