// Напишите программу, в которой пользователь задает длину массива,
// элементы которого задаются в диапазоне [1,99] и выводит на экран .
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]


void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

void fillRandomArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void printRandomArray(int[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if(i < col.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
    
}

printInConsoleWithColor("Введите количество элементов массива: ",ConsoleColor.Blue);
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[userNumber];
fillRandomArray(array);

Console.WriteLine("Случайный массив: ");
printRandomArray(array);

