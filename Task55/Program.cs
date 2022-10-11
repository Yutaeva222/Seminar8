// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


Console.WriteLine("Укажите размерность m вашего массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размерность n вашего массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);


void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}