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
ChangeRowsColumns(numbers);
Console.WriteLine();
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
void ChangeRowsColumns(int[,] numbers)
{
    // int rows = numbers.GetLength(0);
    // int columns = numbers.GetLength(1);
    Random random = new Random();
    if (rows == columns)
    {
        // int max_i = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                int temp = numbers[i,j];
                numbers[i,j] = numbers[j,i];
                numbers[j,i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Задача невыполнима, строки и столбцы не равны.");
    }
}