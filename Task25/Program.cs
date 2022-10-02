//  Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

int exponentiation(int userNumberA, int userNumberB)
{   
    int result = 0;
    if(userNumberB != 0)
    {
        result = userNumberA;
        userNumberB = Math.Abs(userNumberB);
        for(int i = 1; i < userNumberB; i++)
        {
             result = result * userNumberA;
        }
    }
    else result = 1;

    return result;
}

printInConsoleWithColor("Введите число А: ",ConsoleColor.DarkGreen );
int userNumberA = Convert.ToInt32(Console.ReadLine());
printInConsoleWithColor("Введите число B: ",ConsoleColor.DarkGreen );
int userNumberB = Convert.ToInt32(Console.ReadLine()); 
double result = exponentiation(userNumberA, userNumberB);

if(userNumberB > 0)
printInConsoleWithColor($"Результат возведения числа {userNumberA} в степень {userNumberB} равен {result}", ConsoleColor.Green);
else printInConsoleWithColor($"Результат возведения числа {userNumberA} в степень {userNumberB} равен {1 / result}", ConsoleColor.Green);