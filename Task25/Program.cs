//  Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int exponentiation(int userNumberA, int userNumberB)
{
    int result = userNumberA;
    userNumberB = Math.Abs(userNumberB);
    for(int i = 1; i < userNumberB; i++)
    {
         result = result * userNumberB;
    }
    return result;
}

Console.Write("Введите число А: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int userNumberB = Convert.ToInt32(Console.ReadLine()); 
double result = exponentiation(userNumberA, userNumberB);

if(userNumberB > 0)
Console.WriteLine($"Результат возведения числа {userNumberA} в степень {userNumberB} равен {result}");
else Console.WriteLine($"Результат возведения числа {userNumberA} в степень {userNumberB} равен {1 / result}");